using System;

namespace enums {
    class Program {
    static void Main (string[] args) {

    var myValues = Enum.GetValues (typeof (enums.Day));
    var myWeek = Enum.GetValues (typeof (enums.Month));
    foreach (var v in myValues) {
    Console.WriteLine (v);
            }
            foreach (var W in myWeek) {
                Console.WriteLine (W);
            }

        }

        public class enums {
            public enum Day { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
            public enum Month { January, February, March, April, May, June, July, August, September, Octoer, November, December };
        }

    }
}