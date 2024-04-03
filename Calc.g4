grammar Calc;

// Define the entry point of the parser.
calc: '{' expr (',' expr)* '}';

// Define what an expression can be.
expr:
	value // An expression can be a value.
	| expr '+' expr // Addition.
	| expr '-' expr // Subtraction.
	| '(' expr ')'; // Parentheses for grouping.

// Define a value as an initialization or an integer.
value:
	calc // Nested structures.
	| INT; // Integer values.

INT: [0-9]+; // Define what an INT is.
WS: [ \t\r\n]+ -> skip; // Ignore whitespace.