grammar Calc;

script: statement*;

statement:
	writeStatement
	| variableDeclaration
	| variableAssignment
	| comment
	| readStatement;

writeStatement:
	'write' STRING ',' expr ';'
	| 'write' STRING ';';

variableDeclaration: type IDENTIFIER ';';

variableAssignment: IDENTIFIER '=' expr ';';

comment: '//' NOT_NEWLINE* NEWLINE;

readStatement: 'read' IDENTIFIER (',' IDENTIFIER)* ';';

type: 'int' | 'float' | 'string' | 'bool';

expr:
	| statement
	| type
	| INT // Integer literal
	| FLOAT // Floating point literal
	| STRING // String literal
	| BOOLEAN // Boolean literal
	| IDENTIFIER // Variable name
	| expr '+' expr // Addition or string concatenation
	| expr '*' expr // Multiplication
	| expr '/' expr // Division
	| expr '%' expr // Modulus (remainder)
	| '(' expr ')'; // Parenthesized expr

INT: [0-9]+;
FLOAT: [0-9]+ '.' [0-9]*;
STRING: '"' (ESC | .)*? '"';
BOOLEAN: 'true' | 'false';
IDENTIFIER: [a-zA-Z_][a-zA-Z0-9_]*;
WS: [ \t\r\n]+ -> skip;
COMMENT: '//' ~[\r\n]*;
NOT_NEWLINE: ~[\r\n];
NEWLINE: '\r'? '\n' | '\r';
ESC: '\\' ('"' | 'n' | 't' | '\\' | '/');