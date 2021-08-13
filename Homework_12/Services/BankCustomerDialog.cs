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
        public BankCustomer CreateNewBankCustomer(Status clientStatus)
        {
            var dialog = new AddBankCustomersWindow();

            if (dialog.ShowDialog() != true) return null;

            return CreateBankCustomer(dialog, clientStatus);
        }

        /// <summary>
        /// Обновить данные клиента банка
        /// </summary>
        /// <param name="bankCustomer"> Клиент банка </param>        
        public BankCustomer UpdateDataBankCustomer(IBankCustomer bankCustomer)
        {
            if (bankCustomer is null)
                throw new ArgumentNullException("Клиент банка не может быть null!!!");

            var dialog = new AddBankCustomersWindow();

            FillInWindows(dialog, bankCustomer);

            if (dialog.ShowDialog() != true) return null;

            var tempBankCustomer = CreateBankCustomer(dialog, bankCustomer.ClientStatus);
            tempBankCustomer.Id = bankCustomer.Id;

            return tempBankCustomer;
        }

        /// <summary>
        /// Создать клиента банка
        /// </summary>
        /// <param name="dialog"> Окно диалога </param>
        /// <param name="clientStatus"> Статус клиента </param>        
        private BankCustomer CreateBankCustomer(AddBankCustomersWindow dialog,
                                                Status clientStatus)
        {
            if (dialog is null)
                throw new ArgumentNullException(nameof(dialog));

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

            return new BankCustomer(0,
                                    passport,
                                    clientStatus,
                                    dialog.PhoneNumber,
                                    dialog.Reliability,
                                    dialog.Email);
        }

        /// <summary>
        /// Заполнение полей окна
        /// </summary>
        /// <param name="dialog"> Окно диалога </param>
        /// <param name="bankCustomer"> Клиент банка </param>
        private void FillInWindows(AddBankCustomersWindow dialog,
                                   IBankCustomer bankCustomer)
        {
            if (dialog is null)
                throw new ArgumentNullException(nameof(dialog));

            if (bankCustomer is null)
                throw new ArgumentNullException(nameof(bankCustomer));

            dialog.PhoneNumber = bankCustomer.PhoneNumber;
            dialog.Email = bankCustomer.Email;
            dialog.Description = bankCustomer.Description;
            dialog.Reliability = bankCustomer.Reliability;

            dialog.NameBankCustomer = bankCustomer.Passport.Holder.Name;
            dialog.SurnameBankCustomer = bankCustomer.Passport.Holder.Surname;
            dialog.PatronymicBankCustomer = bankCustomer.Passport.Holder.Patronymic;
            dialog.BirthdayBankCustomer = bankCustomer.Passport.Holder.Birthday;
            dialog.GenderBankCustomer = bankCustomer.Passport.Holder.Gender;
            dialog.PlaceOfBirthBankCustomer = bankCustomer.Passport.Holder.PlaceOfBirth;

            dialog.SeriesPassport = bankCustomer.Passport.Series;
            dialog.NumberPassport = bankCustomer.Passport.Number;
            dialog.DivisionCodeLeftPassport = bankCustomer.Passport.DivisionCode.Left;
            dialog.DivisionCodeRightPassport = bankCustomer.Passport.DivisionCode.Right;
            dialog.DateOfIssuePassport = bankCustomer.Passport.DateOfIssue;
            dialog.PlaceOfIssuePassport = bankCustomer.Passport.PlaceOfIssue;

            dialog.RegionPlaceOfResidence = bankCustomer.Passport.Holder.PlaceOfResidence.Region;
            dialog.CityPlaceOfResidence = bankCustomer.Passport.Holder.PlaceOfResidence.City;
            dialog.DistrictPlaceOfResidence = bankCustomer.Passport.Holder.PlaceOfResidence.District;
            dialog.StreetPlaceOfResidence = bankCustomer.Passport.Holder.PlaceOfResidence.Street;
            dialog.HouseNumberPlaceOfResidence = bankCustomer.Passport.Holder.PlaceOfResidence.HouseNumber;
            dialog.HousingPlaceOfResidence = bankCustomer.Passport.Holder.PlaceOfResidence.Housing;
            dialog.ApartmentNumberPlaceOfResidence = bankCustomer.Passport.Holder.PlaceOfResidence.ApartmentNumber;
            dialog.RegistrationDatePlaceOfResidence = bankCustomer.Passport.Holder.PlaceOfResidence.RegistrationDate;

            if (bankCustomer.Passport.Holder.PlaceOfRegistration != null)
            {
                dialog.RegionRegistration = bankCustomer.Passport.Holder.PlaceOfRegistration.Region;
                dialog.CityRegistration = bankCustomer.Passport.Holder.PlaceOfRegistration.City;
                dialog.DistrictRegistration = bankCustomer.Passport.Holder.PlaceOfRegistration.District;
                dialog.StreetRegistration = bankCustomer.Passport.Holder.PlaceOfRegistration.Street;
                dialog.HouseNumberRegistration = bankCustomer.Passport.Holder.PlaceOfRegistration.HouseNumber;
                dialog.HousingRegistration = bankCustomer.Passport.Holder.PlaceOfRegistration.Housing;
                dialog.ApartmentNumberRegistration = bankCustomer.Passport.Holder.PlaceOfRegistration.ApartmentNumber;
                dialog.RegistrationDateRegistration = bankCustomer.Passport.Holder.PlaceOfRegistration.RegistrationDate;
            }
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
                return new DivisionCode(left, right);
            }
            catch (Exception)
            {
                return null;
            }
        }        
    }
}
