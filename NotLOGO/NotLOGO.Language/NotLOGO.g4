grammar NotLOGO;

/* LEXICAL RULES */

/* keywords */
PENUP_KW	:	'penup';
FD_KW		:	'fd';
LT_KW		:	'lt';
RT_KW		:	'rt';
BD_KW		:	'bd';
PENDOWN_KW	:	'pendown';
PENCOLOR_KW	:	'pencolor';

/* values */
INT_VAL			:	[0-9]+;
HEXCOLOR_VAL	:	'#'[0-9a-fA-F]+;

/* misc */
WS  :   [ \r\t\u000C\n]+ -> skip;
COMMENT	:	'/*'(.)*'*/' -> skip;

/* SYNTAX RULES */