using System;
class OTPGenerator{

    // Random number generator
    static Random random = new Random();   
    // Method to generate a 6-digit OTP
    public static int GenerateOTP(){
        return random.Next(100000, 1000000);
    }

    // Method to check if OTPs are unique
    public static bool AreOTPsUnique(int[] otp){
        for (int i = 0; i < otp.Length; i++){
            for (int j = i + 1; j < otp.Length; j++){
                if (otp[i] == otp[j])
                    return false;
            }
        }
        return true;
    }

    public static void Main(string[] args){

        // Generating and displaying 10 OTPs 
        int[] otpArray = new int[10];
        Console.WriteLine("Generated OTPs:");
        for (int i = 0; i < otpArray.Length; i++){
            otpArray[i] = GenerateOTP();
            Console.WriteLine("OTP " +(i + 1)+ ": "+otpArray[i]);
        }
        

        // Checking if OTPs are unique or not
        if (AreOTPsUnique(otpArray)){
            Console.WriteLine("All OTPs are UNIQUE.");
        }else{
            Console.WriteLine("Duplicate OTPs are found.");
        }
    }
}
