ö
[C:\Users\pkolosov\RiderProjects\CodeFirstEntityFrameworkCore\CodeFirst.ConsoleUI\Program.cs
	namespace 	
	CodeFirst
 
. 
	ConsoleUI 
{		 
public

 

static

 
class

 
Program

 
{ 
private 
static 
async 
Task !
Main" &
(& '
)' (
{ 	
using 
( 
var 
context 
=  
new! $
SqlServerDbContext% 7
(7 8
)8 9
)9 :
{ 
var 
query 
= 
context #
.# $
Movies$ *
.* +
Include+ 2
(2 3
x3 4
=>5 7
x8 9
.9 :
Copies: @
)@ A
;A B
Console 
. 
	WriteLine !
(! "
query" '
.' (
ToQueryString( 5
(5 6
)6 7
)7 8
;8 9
} 
} 	
}   
}!! 