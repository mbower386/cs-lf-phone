using System;
using PhoneProject.IRingableClass;
using PhoneProject.PhoneClass;

namespace PhoneProject.NokiaClass
{
    public class Nokia : Phone, IRingable
    {
        public Nokia (string versionNumber, int batteryPercentage, string carrier, string ringTone) : base (versionNumber, batteryPercentage, carrier, ringTone) { }
        public string Ring ()
        {
            // your code here
            return Ringtone;
        }
        public string Unlock ()
        {
            // your code here
            return "Nokia " + VersionNumber + " unlocked with passcode";
        }
        public override void DisplayInfo ()
        {
            // your code here            
            Console.WriteLine ("$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine ("Nokia " + VersionNumber);
            Console.WriteLine ("Battery Percentage: " + BatteryPercentage);
            Console.WriteLine ("Carrier: " + Carrier);
            Console.WriteLine ("Ring Tone: " + Ringtone);
            Console.WriteLine ("$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        }
    }

}