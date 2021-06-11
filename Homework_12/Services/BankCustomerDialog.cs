using Enums;
using Interfaces;
using Models;
using System;
using Views;

namespace Services
{
    public class BankCustomerDialog : IBankCustomerDialogService
    {
        /// <summary>
        /// Создать нового клиента банка
        /// </summary>
        /// <param name="clientStatus"> Статус </param>        
        public BankCustomer CreateNewBankCustomer(ClientStatus clientStatus)
        {
            var dialog = new AddBankCustomersWindow();

            if (dialog.ShowDialog() != true) return null;

            var residenceAddress = CreateAddress(dialog.RegistrationDatePlaceOfResidence,
                                                 dialog.RegionPlaceOfResidence,
                                                 dialog.CityPlaceOfResidence,
                                                 dialog.StreetPlaceOfResidence,
                                                 dialog.HouseNumberPlaceOfResidence,
                                                 dialog.ApartmentNumberPlaceOfResidence,
                                                 dialog.HousingPlaceOfResidence,
                                                 dialog.DistrictPlaceOfResidence);

            if (residenceAddress is null) return null;

            var registrationAddress = CreateAddress(dialog.RegistrationDateRegistration,
                                                    dialog.RegionRegistration,
                                                    dialog.CityRegistration,
                                                    dialog.StreetRegistration,
                                                    dialog.HouseNumberRegistration,
                                                    dialog.ApartmentNumberRegistration,
                                                    dialog.HousingRegistration,
                                                    dialog.DistrictRegistration);

            var persone = CreatePersone(dialog.SurnameBankCustomer,
                                        dialog.NameBankCustomer,
                                        dialog.PatronymicBankCustomer,
                                        dialog.GenderBankCustomer,
                                        dialog.BirthdayBankCustomer,
                                        dialog.PlaceOfBirthBankCustomer,
                                        residenceAddress,
                                        registrationAddress);

            if (persone is null) return null;

            var divisionCode = CreateDivisionCode(dialog.DivisionCodeLeftPassport,
                                                  dialog.DivisionCodeRightPassport);

            if (divisionCode is null) return null;

            var passport = CreatePassport(dialog.SeriesPassport,
                                          dialog.NumberPassport,
                                          dialog.PlaceOfIssuePassport,
                                          dialog.DateOfIssuePassport,
                                          divisionCode,
                                          persone);

            if (passport is null) return null;

            return new BankCustomer(passport, clientStatus);
        }

        /// <summary>
        /// Изменить паспорт
        /// </summary>
        /// <param name="bankCustomer"> Клиент банка </param>
        public Passport ReplacePassport(IBankCustomer bankCustomer)
        {
            if (bankCustomer is null)
                throw new ArgumentNullException("Клиент банка не может быть null!!!");

            var dialog = new PassportWindow();

            dialog.Number = bankCustomer.Passport.Number;
            dialog.Series = bankCustomer.Passport.Series;
            dialog.DivisionCodeLeft = bankCustomer.Passport.DivisionCode.Left;
            dialog.DivisionCodeRight = bankCustomer.Passport.DivisionCode.Right;
            dialog.DateOfIssue = bankCustomer.Passport.DateOfIssue;
            dialog.PlaceOfIssue = bankCustomer.Passport.PlaceOfIssue;

            if (dialog.ShowDialog() != true) return null;

            var divisionCode = CreateDivisionCode(dialog.DivisionCodeLeft,
                                                  dialog.DivisionCodeRight);

            if (divisionCode is null) return null;


            var passport = CreatePassport(dialog.Series,
                                          dialog.Number,
                                          dialog.PlaceOfIssue,
                                          dialog.DateOfIssue,
                                          divisionCode,
                                          bankCustomer.Passport.Holder);

            if (passport.Equals(bankCustomer.Passport)) return null;

            return passport;
        }

        /// <summary>
        /// Добавить описание
        /// </summary>
        /// <param name="bankCustomer"> Клиент банка </param>
        public string AddDescription(BankCustomer bankCustomer)
        {
            if (bankCustomer is null)
                throw new ArgumentNullException("Клиент банка не может быть null!!!");

            var dialog = new AddDescriptionWindow();
            dialog.Description = bankCustomer.Description;
            if (dialog.ShowDialog() != true) return null;

            string description = dialog.Description;
            if (string.IsNullOrWhiteSpace(description)) return null;
            if (bankCustomer.Description == description) return null;

            return description;
        }

        public void AddEmail(IBankCustomer bankCustomer)
        {
            
        }

        public void AddPhoneNumber(IBankCustomer bankCustomer)
        {
           
        }

        public void ChangeReliability(IBankCustomer bankCustomer)
        {
            
        }

        /// <summary>
        /// Создание адреса
        /// </summary>
        /// <param name="registrationDate"> Дата регистрации </param>
        /// <param name="region"> Регион или Область </param>
        /// <param name="city"> Город </param>
        /// <param name="street"> Улица </param>
        /// <param name="houseNumber"> Дом </param>
        /// <param name="apartmentNumber"> Номер квартиры </param>
        /// <param name="housing"> Корпус дома </param>
        /// <param name="district"> Район города </param>        
        private IAddress CreateAddress(DateTime registrationDate,
                                       string region,
                                       string city,
                                       string street,
                                       int houseNumber,
                                       int apartmentNumber,
                                       string housing,
                                       string district)
        {
            try
            {
                return new Address(registrationDate,
                                   region,
                                   city,
                                   street,
                                   houseNumber,
                                   apartmentNumber,
                                   housing,
                                   district);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Создание гражданина
        /// </summary>
        /// <param name="surname"> Фамилия </param>
        /// <param name="name"> Имя </param>
        /// <param name="patronymic"> Отчество </param>
        /// <param name="gender"> Пол </param>
        /// <param name="birthday"> День рождения </param>
        /// <param name="placeOfBirth"> Место рождения </param>
        /// <param name="placeOfResidence"> Место жительства (прописка) </param>
        /// <param name="placeOfRegistration"> Место регистрации </param>
        private IPerson CreatePersone(string surname,
                                      string name,
                                      string patronymic,
                                      string gender,
                                      DateTime birthday,
                                      string placeOfBirth,
                                      IAddress placeOfResidence,
                                      IAddress placeOfRegistration)
        {
            try
            {
                return new Person(surname,
                                  name,
                                  patronymic,
                                  gender,
                                  birthday,
                                  placeOfBirth,
                                  placeOfResidence,
                                  placeOfRegistration);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Создание паспорта
        /// </summary>
        /// <param name="series"> Серия </param>
        /// <param name="number"> Номер </param>
        /// <param name="placeOfIssue"> Место выдачи </param>
        /// <param name="dateOfIssue"> Дата выпуска </param>
        /// <param name="divisionCode"> Код подразделения </param>
        /// <param name="holder"> Владелец </param>
        private Passport CreatePassport(long series,
                                        long number,
                                        string placeOfIssue,
                                        DateTime dateOfIssue,
                                        DivisionCode divisionCode,
                                        IPerson holder)
        {
            try
            {
                return new Passport(series,
                                    number,
                                    placeOfIssue,
                                    dateOfIssue,
                                    divisionCode,
                                    holder);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Создать Код подразделения
        /// </summary>
        /// <param name="left"> Левая чать кода </param>
        /// <param name="right"> Правая часть кода </param>        
        private DivisionCode CreateDivisionCode(int left, int right)
        {
            try
            {
                return new DivisionCode(left , right);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
