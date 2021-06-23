# _201501001_Enes_Akyar
# _201501001_Enes_Akyar

WELCOME SCREEN(HOŞGELDİN EKRANI)

-10 seconds after the main screen is opened, this screen is hidden and the user screen is opened, or if the university logo is clicked, this screen will be hidden without waiting for 10 seconds and the user login screen will open.

-Clicking on the sign-up label opens the registration screen.

REGISTRATION SCREEN(KAYIT EKRANI)

-It checks all fields and gives a warning if there is an empty field.

-Password must be at least 6 characters. It gives a warning if it is less than 6 characters.

-It generates 2 random numbers between -1 and 100 and displays it as a total on the screen. If the user enters the sum of these two numbers incorrectly, it gives a warning and changes the numbers.

-If there is a TC number and password in the registration.txt file, it will redirect to the Game screen. If it can't find it in the kayit.txt file, it will warn and replace 2 random numbers with new ones.(@"c:\gorsel\kayit.txt")

-It gives a warning if all fields are not filled.

-Password must be at least 6 characters. It gives a warning if it is less than 6 characters.

-When the number of characters in the password textbox is greater than 6, the Save button becomes active. In other cases, it remains inactive.

-It gives a warning if there is a user with the ID number entered in the registry file.

-Performs user authentication with Mernis. It throws an error if the validation fails.

-If it gives an error while converting the ID number data to long type, it writes the date(DateTime.Now) and the error message to the error.txt file. (@"c:\image\error.txt")

-If the above errors are not stuck, add the user to the registration.txt file in order.

-It saves as Guid, name, surname, year of birth, TC no, password.(@"c:\image\registration.txt")

GAME SCREEN(OYUN EKRANI)

-When the Close Application button is pressed, it closes the application.

-When the New Game button is pressed, it starts the number guessing game.

-Time increases every second and appears on the screen.

-When the user guesses correctly, it saves the user's userID, rights, seconds, date information in the game.txt file, respectively.(@"c:\image\game.txt";)

   I.userID->Guid number you gave when you registered the user

   ii.right->user guessed correctly on how many attempts

   iii.seconds->guessed correctly after how many seconds.

   iv.date->date he knows correct

-Shows the right and seconds information of the games played by the user in the previous scores.
