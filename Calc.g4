grammar Calc;

prog: (decl | expr | assignExpr | statement)+ EOF;

decl: ID ':' DATA_TYPE '=' value ';';
assignExpr: ID ':' DATA_TYPE '=' expr ';';

expr:
	expr operation expr
	| ID
	| value
	| forLoop
	| assignment
	| up
	| comparison
	| declaration
	| '(' expr ')' symbol = '?' expr ':' expr;

operation: '*' | '/' | '+' | '-' | '?';
statement: forLoop | OTHER_STATEMENT;

OTHER_STATEMENT: . -> skip;

COMMENT: '//' ~[\r\n]* -> skip;
WS: [ \t\n\r]+ -> skip;

DATA_TYPE: 'int' | 'float' | 'string' | 'bool';
ID: [a-zA-Z]+;
value: NUM | STRING | BOOLEAN;
NUM: '0' | ('-'? [1-9][0-9]* | [0-9]) (.[0-9]+)?;
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
declaration: '<' ID '>';