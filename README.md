Issue 1
Got error CS0535 indicating the class didn't implement interface correctly

Solution 1: Silly typo in the interface, GetSpell was instead GetSpells. Removed the s and now it's fixed.

Issue 2
Calling the GetSpell method in the main program makes doesn't wait for the method, so it basically skips it.

Solution 1: Convert what was written to a static async. It got rid of the error, but then it led into another problem.

Issue 2.1
Couldn't use the input I wanted, though I tried putting a variable in a method (which is a no-no), fixed it by basically making a new method and putting in the process I wanted originally in this method and making it "await", so no more error like before.

Issue 3
The program doesn't seem to be printing what's asked for, so either I didn't implement the API right, or I just need to find a specific way to print it.

Solution(?): It seems like it wasn't even reaching the FifthEAPIService class at all at first. I switched some stuff around, removed the I5eAPIService from the mix, I changed the connection to the data class for now, and changed the output to just grab the name for now and that seemed to actually reach it this time

Issue 4
Problems with writing out what I wanted, as I was trying to return and print it out in the actual Main in Program. While the "name" value would successfully change to the name of the spell acquired from the API, it couldn't be returned back to the Main.

Solution: Manually made a WriteLine for each value that was wanted. Formatting for the description is strange, but it technically works so it'll stay for now.