using System;
using PhoneProject.IRingableClass;
using PhoneProject.PhoneClass;

namespace PhoneProject.GalaxyClass
{
    public class Galaxy : Phone, IRingable
    {
        public Galaxy (string versionNumber, int batteryPercentage, string carrier, string ringTone) : base (versionNumber, batteryPercentage, carrier, ringTone) { }
        public string Ring ()
        {
            // your code here
            return "\n... " + Ringtone + " ...";
        }
        public string Unlock ()
        {
            // your code here
            return "Galaxy " + VersionNumber + " unlocked with fingerprint scanner";
        }
        public override void DisplayInfo ()
        {
            // your code here
            Console.WriteLine ("#############################");
            Console.WriteLine ("Galaxy " + VersionNumber);
            Console.WriteLine ("Battery Percentage: " + BatteryPercentage);
            Console.WriteLine ("Carrier: " + Carrier);
            Console.WriteLine ("Ring Tone: " + Ringtone);
            Console.WriteLine ("#############################");
        }
    }

}