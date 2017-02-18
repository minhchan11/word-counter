# WORD COUNTERS

#### A web app that counts word in a string

#### By Minh Phuong

## Description
* A website in Nancy that uses a method to return how frequently a word appears in a given string. The user should input both the word and the string of words to check. Check for full word matches only.

## Setup/Installation Requirements
* Clone From GitHub
* Open a cmd program
* Navigate to downloaded folder
* Type in cmd window "dnx kestrel"
* Enter this url in desired browser http://localhost:5004

## Specification
* The program will determine that only letters and capital letters are entered, no number or special characters
  * Input: "4546"
 <!-- (limit the input for the app -->
  * Output: False
* The program will determine that only one word is entered
  * Input: "the cat"
 <!-- (limit the behavior of the app -->
  * Output: False
* The user will input a word and a string. The program will detect if the word is present in the string.
  * Input: "cat", "I have a cat in the cathedral"
  <!-- (simplest find match for 1 word) -->
  * Output: True
* The user will input a word and a string. The program will detect if the word is not present in the string.
  * Input: "dog", "I have a cat in the cathedral"
  <!-- (simplest find match case for no match) -->
  * Output: True
* The user will input a word and a string. The program will detect if the word is present in the string regardless of capital cases.
  * Input: "CaT", "I have a cat in the cathedral"
  <!-- (simplest find match case for capital) -->
  * Output: True
* The user will input a word and a string. The program will detect if the word is present in the string and count all the incidents to return the total count only for full match.
  * Input: "cat", "I have a cat in the cathedral"
  <!-- (simplest find match case) -->
  * Output: 1
* The user will input a word and a string. The program will detect if the word is present in the string and count all the incidents to return the total count only for full match, regardless of case.
  * Input: "cat", "CAT CAT cat"
  <!-- (simplest find match case for full match) -->
  * Output: 3
* The user will input a word and a string. The program will detect if the word is present in the string and count all the incidents to return the total count for partial match.
  * Input: "cat", "I have a cat in the cathedral" (simplest find match case)
  <!-- (simplest find match case for partial with repeated letters in that order) -->
  * Output: 2
* The user will input a word and a string. The program will detect if the word is present in the string and count all the incidents to return the total count for partial match regardless of case.
  * Input: "cat", "I brought my CaT to the cAThedral in a CAThouse"
  <!-- (simplest find match case for partial with repeated letters in that order, regardless of case) -->
  * Output: 3

## Known Bugs

No known bugs

## Support and contact details

Contact me at mphuong@kent.edu.

## Technologies Used

HTML, CSS, Bootstrap, C#, Nancy, Razor.

### License

Copyright (c) 2017 *Minh Phuong*
