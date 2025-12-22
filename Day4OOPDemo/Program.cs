using Day4OOPDemo;
using System;

namespace Day4OOPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Input
            Console.Write("Enter Passenger ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Passenger Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter Travel Type (1-Bus, 2-Train, 3-Flight): ");
            int travelType = int.Parse(Console.ReadLine());

            Console.Write("Enter Base Fare: ");
            double baseFare = double.Parse(Console.ReadLine());

            Console.Write("Is Government Employee (true/false): ");
            bool isGovEmployee = bool.Parse(Console.ReadLine());

            // Step 2: Age Validation (if / else)
            if (age < 5)
            {
                Console.WriteLine("Free Ticket – No Booking Required");
                return;
            }
            else if (age > 80)
            {
                Console.WriteLine("Medical Clearance Required");
                return;
            }

            Passenger passenger = new Passenger
            {
                PassengerId = id,
                Name = name,
                Age = age,
                IsGovEmployee = isGovEmployee
            };

            string travelTypeName = "";
            string className = "";
            double multiplier = 1.0;

            // Step 3: switch + nested switch
            switch (travelType)
            {
                case 1: // Bus
                    travelTypeName = "Bus";
                    Console.Write("Select Class (1-Sleeper, 2-Seater): ");
                    int busClass = int.Parse(Console.ReadLine());

                    switch (busClass)
                    {
                        case 1:
                            className = "Sleeper";
                            multiplier = 1.2;
                            break;
                        case 2:
                            className = "Seater";
                            multiplier = 1.0;
                            break;
                        default:
                            Console.WriteLine("Invalid Bus Class");
                            return;
                    }
                    break;

                case 2: // Train
                    travelTypeName = "Train";
                    Console.Write("Select Class (1-General, 2-Sleeper, 3-AC): ");
                    int trainClass = int.Parse(Console.ReadLine());

                    switch (trainClass)
                    {
                        case 1:
                            className = "General";
                            multiplier = 1.0;
                            break;
                        case 2:
                            className = "Sleeper";
                            multiplier = 1.3;
                            break;
                        case 3:
                            className = "AC";
                            multiplier = 1.6;
                            break;
                        default:
                            Console.WriteLine("Invalid Train Class");
                            return;
                    }
                    break;

                case 3: // Flight
                    travelTypeName = "Flight";
                    Console.Write("Select Class (1-Economy, 2-Business): ");
                    int flightClass = int.Parse(Console.ReadLine());

                    switch (flightClass)
                    {
                        case 1:
                            className = "Economy";
                            multiplier = 2.5;
                            break;
                        case 2:
                            className = "Business";
                            multiplier = 3.5;
                            break;
                        default:
                            Console.WriteLine("Invalid Flight Class");
                            return;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid Travel Type");
                    return;
            }

            // Step 4: Fare calculation
            double fareAfterClass = baseFare * multiplier;

            FareCalculator calculator = new FareCalculator();
            double finalFare = calculator.CalculateFinalFare(
                age,
                isGovEmployee,
                fareAfterClass,
                out string discountType
            );

            // Step 6: Nested decision making
            string bookingStatus;
            if (finalFare >= 10000)
            {
                if (travelType == 3)
                    bookingStatus = "Confirmed";
                else
                    bookingStatus = "Waiting List";
            }
            else
            {
                bookingStatus = "Confirmed";
            }

            Ticket ticket = new Ticket
            {
                TravelType = travelTypeName,
                ClassName = className,
                BaseFare = baseFare,
                FinalFare = finalFare,
                Discount = discountType,
                BookingStatus = bookingStatus
            };

            // Step 7: Output
            Console.WriteLine("\nTICKET ");
            Console.WriteLine($"Passenger ID   : {passenger.PassengerId}");
            Console.WriteLine($"Passenger Name : {passenger.Name}");
            Console.WriteLine($"Age            : {passenger.Age}");
            Console.WriteLine($"Travel Type    : {ticket.TravelType}");
            Console.WriteLine($"Class          : {ticket.ClassName}");
            Console.WriteLine($"Base Fare      : {ticket.BaseFare}");
            Console.WriteLine($"Final Fare     : {ticket.FinalFare}");
            Console.WriteLine($"Discount       : {ticket.Discount}");
            Console.WriteLine($"Booking Status : {ticket.BookingStatus}");

            Console.ReadLine();
        }
    }
}
