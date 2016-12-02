#repeat-counter-csharp

#####This project counts the number of times a string is found in a second string

#####By Anthony J Bottemiller - 11-18-2016

##Description
This page is intended to allow the user to input two strings and return to the user a result of how many times a particular string is found in another if at all.

##Technologies Used
* HTML
* CSS
* BOOTSTRAP
* C#
* Mono
* Nancy
* Razor
* xUnit

##Requirements
* Modern Web Browser
* Mono
* DVNM Scripts
* Internet Access

##Installation
* Clone repository
* Using command line change working directory to cloned repository
* Execute command "dnu restore"
* Start web server "dnx kestrel"
* Navigate to web server using Modern Web Browser

##Specifications
| Behavior                                                                                                             | Input        | Output |
|----------------------------------------------------------------------------------------------------------------------|--------------|--------|
| User inputs two words that do not match. Program returns a count of 0                                                | php, java    | 0      |
| User inputs two words that do match. Program returns a count of 1                                                    | php, php     | 1      |
| User inputs more than one word to compare against a single word. Program returns a count equal to number of matches. | php php, php | 2      |

##Legal
Copyright (c) 2016 Anthony J Bottemiller

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.