grammar Calc;

script: statement*;

statement:
	writeStatement
	| variableDeclaration
	| variableAssignment
	| comment
	| readStatement;

writeStatement: 'write' writeContent+ ';';

writeContent:
	STRING
	| expr
	| ','; // Allows commas between expressions in a write statement

variableDeclaration:
	type IDENTIFIER ('=' expr)? ';'; // Allows for variable initialization

variableAssignment: IDENTIFIER '=' expr ';';

comment: '//' NOT_NEWLINE* NEWLINE;

readStatement: 'read' IDENTIFIER (',' IDENTIFIER)* ';';

type: 'int' | 'float' | 'string' | 'bool';

expr:
	| INT // Integer literal
	| FLOAT // Floating point literal
	| STRING // String literal
	| BOOLEAN // Boolean literal
	| IDENTIFIER // Variable name
	| expr '+' expr // Addition, string concatenation
	| expr '*' expr // Multiplication
	| expr '/' expr // Division
	| expr '%' expr // Modulus (remainder)
	| '(' expr ')'; // Parenthesized expr

INT: [0-9]+ | '-' [0-9]+; // Adjusted to allow negative integers
FLOAT:
	[0-9]+ '.' [0-9]*
	| '-' [0-9]+ '.' [0-9]*; // Adjusted to allow negative floats
STRING: '"' (ESC | .)*? '"';
BOOLEAN: 'true' | 'false';
IDENTIFIER: [a-zA-Z_][a-zA-Z0-9_]*;
WS: [ \t\r\n]+ -> skip;
COMMENT:
	'//' ~[\r\n]*; // This might be redundant with the 'comment' rule
NOT_NEWLINE: ~[\r\n];
NEWLINE: '\r'? '\n' | '\r';
ESC: '\\' ('"' | 'n' | 't' | '\\' | '/');