grammar Calc;

prog: (decl | expr | assignExpr | statement)+ EOF;

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
	| BOOLEAN
	| forLoop
	| assignment
	| up
	| comparison;

statement: forLoop | OTHER_STATEMENT;

OTHER_STATEMENT: . -> skip;

COMMENT: '//' ~[\r\n]* -> skip;
WS: [ \t\n\r]+ -> skip;

DATA_TYPE: 'int' | 'string' | 'bool';
ID: [a-zA-Z]+;
NUM: '0' | '-'? [1-9][0-9]*;
STRING: '"' (~["\r\n] | '""')* '"';
BOOLEAN: 'true' | 'false';
assignment: ID '=' NUM;
up: ID '++' | ID '--';
// Define a comparison (e.g., "i < 10").
comparison: ID ('<' | '>' | '==' | '<=' | '>=') NUM;
forLoop:
	'for' '(' ID '=' NUM ';' comparison ';' up '){' (
		decl
		| expr
		| assignExpr
		| statement
	)+ '}';