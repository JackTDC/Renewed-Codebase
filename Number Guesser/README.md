# Summary

This code is a console application in C# for a **number guessing game**.

The program starts by printing a welcome message to the console. It then prompts the user to enter the **minimum** and **maximum** numbers for the range in which the user's secret number lies. The input is validated, and if the minimum number is larger than the maximum number, the user is prompted to try again.

After the valid input is obtained, the program proceeds to guess the user's number using a **binary search algorithm**. It takes the average of the minimum and maximum values and uses that as its initial guess. It then prompts the user to indicate whether the guess is correct, higher than the user's number, or lower than the user's number.

Based on the user's response, the program **adjusts the range of possible values** for the next guess. If the guess is correct, the program prints a message indicating that it has guessed the user's number and exits. Otherwise, it repeats the guessing process until the correct number is guessed.


> **Note:** The old version can cause many errors, so its easier to break it. 
