using System;


namespace AssessmentOne
{
    public class TicketPriceController
    {
        public decimal Adult_Before_5(int prQuantity, string prPerson, string prDay, decimal prTime)
        {
            var ticketPrice = 14.50M;
            decimal result = -1;

            if (prPerson.ToLower() != "adult" || prDay.ToLower() == "tuesday" || prQuantity < 1 || prTime >= 5)
            {
                return result;
            }
            else
            {
                result = ticketPrice * prQuantity;
                return result;
            }
        }

        public decimal Adult_After_5(int prQuantity, string prPerson, string prDay, decimal prTime)
        {
            var ticketPrice = 17.50M;
            decimal result = -1;

            if (prPerson.ToLower() != "adult" || prDay.ToLower() == "tuesday" || prQuantity < 1 || prTime < 5)
            {
                return result;
            }
            else
            {
                result = ticketPrice * prQuantity;
                return result;
            }
        }


        public decimal Adult_Tuesday(int prQuantity, string prPerson, string prDay)
        {
            var ticketPrice = 13.00M;
            decimal result = -1;

            if (prPerson.ToLower() == "adult" && prDay.ToLower() == "tuesday" && prQuantity >= 1)
            {
                result = ticketPrice * prQuantity;
                return result;
            }

            return result;
        }

        public decimal Child_Under_16(int prQuantity, string prPerson)
        {
            var ticketPrice = 12.00M;
            decimal result = -1;

            if (prPerson.ToLower() == "child" && prQuantity >= 1)
            {
                result = ticketPrice * prQuantity;
                return result;
            }

            return result;
        }

        public decimal Senior(int prQuantity, string prPerson)
        {
            var ticketPrice = 12.50M;
            decimal result = -1;

            if (prPerson.ToLower() == "senior" && prQuantity >= 1)
            {
                result = ticketPrice * prQuantity;
                return result;
            }

            return result;
        }

        public decimal Student(int prQuantity, string prPerson)
        {
            var ticketPrice = 14.00M;
            decimal result = -1;

            if (prPerson.ToLower() == "student" && prQuantity >= 1)
            {
                result = ticketPrice * prQuantity;
                return result;
            }

            return result;
        }


        public decimal Family_Pass(int prQuantityTicket, int prQuantityAdult, int prQuantityChild)
        {
            var ticketPrice = 46.00M;
            decimal result = -1;

            if (prQuantityTicket >= 1 && prQuantityAdult == 2 && prQuantityChild == 2 ||
                prQuantityTicket >= 1 && prQuantityAdult == 1 && prQuantityChild == 3)
            {
                result = ticketPrice * prQuantityTicket;
                return result;
            }

            return result;
        }

        public decimal Chick_Flick_Thursday(int prQuantity, string prPerson, string prDay)
        {
            var ticketPrice = 21.50M;
            decimal result = -1;

            if (prPerson.ToLower() == "adult" && prDay.ToLower() == "thursday" && prQuantity >= 1)
            {
                result = ticketPrice * prQuantity;
                return result;
            }

            return result;
        }


        public decimal Kids_Careers(int prQuantity, string prDay, bool prHoliday)
        {
            var ticketPrice = 12.00M;
            decimal result = -1;

            if (prQuantity >= 1 && prDay.ToLower() == "wednesday" && prHoliday == false)
            {
                result = ticketPrice * prQuantity;
                return result;
            }

            return result;
        }
    }
}