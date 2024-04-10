grammar Calc;

prog: (decl | expr)+ EOF;

decl: ID '=' NUM ';';
assignExpr: ID '=' expr ';';
expr:
	expr '*' expr
	| expr '/' expr
	| expr '+' expr
	| expr '-' expr
	| DATA_TYPE
	| ID
	| NUM;

NUM: '0' | '-'? [1-9][0-9]*;
ID: [a-zA-Z]+;
DATA_TYPE: 'int' | 'float' | 'double' | 'char';
COMMENT: '//' ~[\r\n]* -> skip;
WS: [ \t\n\r]+ -> skip;