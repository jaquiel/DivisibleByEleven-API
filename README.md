# DivisibleByEleven-API

DivisibleByEleven-API is a Web API whose main objective is to receive a request in JSON format containing a list of
numbers. The answer must state for each number whether or not it is a multiple of 11 (given a positive number N, determine whether
it is a multiple of eleven). 

## How it works

To run the Web Api you need to follow one of the ways below:
- The first one is download the project, clicking in the Code button, in the top of this repository and then Download ZIP, select a path and when the folder to complete the download unzip it. After that, you can run the application using Visual Studio or Visual Studio Code.
- The second option is to use git to get the repository. In this case you can follow the below steps:
  1. type the command below using your favorite CLI tool in any folder:
     ```
      $ git clone https://github.com/jaquiel/DivisibleByEleven-API.git
     ```
  OBS.: After to execute one of the two options above, if you to use Visual Studio (2022, recomended) just open the project in the folder where you saved it and execute it (press the key F5 or click the Run button). In case you prefer to use Visual Studio Code, then go to the projects' folder and excute the commands:
  
  1. To open the VS Code:
  ```
  $ code .
  ```      
  
  2. To execute:
  ```
  $ dotnet run
  ```

## How to use

After execute the project, you can to use the api using a tool like Postman, Insomnia or another you prefer. 
Running the project you can access the link to see the information about Web API that Swagger provides:
```
https://localhost:7087/swagger/
```

The app have only one endpoint
```
https://localhost:7087/divisible/byeleven
```  
### Request example
```
{
  "numbers": [
    "112233",
    "30800",
    "2937",
    "323455693",
    "5038297",
    "112234"
  ]
}
```
### Response example
```
{
	"result": [
		{
			"number": "112233",
			"isMultiple": true
		},
		{
			"number": "30800",
			"isMultiple": true
		},
		{
			"number": "2937",
			"isMultiple": true
		},
		{
			"number": "323455693",
			"isMultiple": true
		},
		{
			"number": "5038297",
			"isMultiple": true
		},
		{
			"number": "112234",
			"isMultiple": false
		}
	]
}
```  

So, if you have success until here, have fun!

## About divisibility by 11

A number is divisible by 11 if the difference between the last digit (the unit digit) and the formed
by the other digits, successively until a number with 2 digits remains, results in a
multiple of 11. As the most immediate rule, all double tens (11, 22, 33, 55, etc.) are multiples of 11.
- 286 → 28 - 6 = 22 → 22 (because it is a double ten) is a multiple of 11
- 1331 → 133 - 1 = 132 → 13 - 2 = 11
- 14641 → 1464 - 1 = 1463 → 146 - 3 = 143 → 14 - 3 = 11
- 24350 → 2435 - 0 = 2435 → 243 - 5 = 238 → 23 - 8 = 15 → is not a multiple of 11
We have yet another method: Add the 1st, 3rd, 5th, 7th digit; if the difference of the sum of
2nd, 4th, 6th, 8th digit; is a multiple of 11 (including zero) then the number is divisible by
11
- 94186565 → 9 + 1 + 6 + 6 = 22 → 4 + 8 + 5 + 5 = 22 → 22 - 22 = 0
- 56568143 → 5 + 5 + 8 + 4 = 22 → 6 + 6 + 1 + 3 = 16 → 22 - 16 = 6
Or if the sum of the digits in even positions and the sum of the digits in odd positions have the
same remainder of division by eleven, then the number taken is divisible by eleven.
- 4611686018427387901307445734561825860123058430092136939501844674407370955160 → 168 = 148 (mod 11) OK
- 4611686018427387903307445734561825860223058430092136939511844674407370955161 → 171 <> 148 (mod 11) Not OK
