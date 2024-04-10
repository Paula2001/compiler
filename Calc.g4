grammar Calc;

prog: (decl | expr | assignExpr)+ EOF;

decl: ID ':' DATA_TYPE '=' (NUM | STRING | BOOLEAN) ';';
assignExpr: ID ':' DATA_TYPE '=' expr ';';
expr:
	expr '*' expr
	| expr '/' expr
	| expr '+' expr
	| expr '-' expr
	| ID
	| NUM
	| STRING
	| BOOLEAN;

COMMENT: '//' ~[\r\n]* -> skip;
WS: [ \t\n\r]+ -> skip;

DATA_TYPE: 'int' | 'string' | 'bool';
ID: [a-zA-Z]+;
NUM: '0' | '-'? [1-9][0-9]*;
STRING: '"' (~["\r\n] | '""')* '"';
BOOLEAN: 'true' | 'false';