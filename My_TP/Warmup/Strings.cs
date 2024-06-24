using System;


namespace My_TP
{
    public class Strings
    {
        // In this function you will have a parameter in argument with the following shape :
        // - "name : My_NaMe"
        // In the name from the string passed in argument, you will have to do reformatting operations.
        // Firstly after separating the name from the original string, you will replace all of the '_' by a Space
        // Secondly, you'll remove all of the characters that are not numbers, letter or spaces.
        // If two or more spaces are following each others, you should remove the excess spaces
        // Then, the letter should all be passed in lower case.
        // The function will return a String of the reformatting name.
        public static String Decode_Name(String message)
        {
            throw new NotImplementedException("not yet implemented");
        }
        
        // In this function you will have a parameter in argument with the following shape :
        // - "age : My_Age"
        // This function will return the age of the string passed in argument converted into an int.
        // For the implementation of this function, the use of iterators will helps you.
        public static int Decode_Age(String message)
        {
            throw new NotImplementedException("not yet implemented");
        }
        
        // The following function will have a parameter in argument with the following shape :
        // - "species : My_Specie_1|My_Specie_2"
        // Here you will have to create a list of all of the species that are contained in the original string.
        // To separate them, the separator used is '|', it should helps you to separates the different species.
        // Before adding the string representing the specie name in the list, you will have to reformat it.
        // Firstly after separating the name from the original string, you will replace all of the '_' by a Space
        // Secondly, you'll remove all of the characters that are not numbers, letter or spaces.
        // If two or more spaces are following each others, you should remove the excess spaces
        // Then, the letter should all be passed in lower case.
        // The function will return a List containing strings of the reformatting species name.
        public static List<String> Decode_species(String message)
        {
            throw new NotImplementedException("not yet implemented");
        }
        
        // In this function, you will have in argument a message which represent multiple caracteristics of the
        // player's character.
        // In this function you will have to use the functions implemented earlier to read the message and complete the 
        // player's character attributes. As result for this function, you will return the attributes of the player's character.
        // The first attribute is the name, the second attribute is the specie and as a third attribute you will find the
        // age of the character.
        // The function returns the three attributes in the order express right before 
        public static (String, String, int) Select_Decoder(List<String> message)
        {
            throw new NotImplementedException("not yet implemented");
        }
    }
}