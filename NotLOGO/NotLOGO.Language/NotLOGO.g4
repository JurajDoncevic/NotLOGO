grammar NotLOGO;

/* LEXICAL RULES */

/* keywords */
KW_PENUP	:	'penup';
KW_PENDOWN	:	'pendown';
KW_FD		:	'fd';
KW_LT		:	'lt';
KW_RT		:	'rt';
KW_BD		:	'bd';
KW_PENCOLOR	:	'pencolor';

/* values */
VAL_INT			:	'-'?[0-9]+;
VAL_HEXCOLOR	:	'#'[0-9a-fA-F]+;

/* misc */
NEWLINE	:	'\r'? '\n' ;	
WS		:   [ \t]+ -> skip;
COMMENT	:	'/*'(.)*'*/' -> skip;

/* SYNTAX RULES */
cmd_penup	:	KW_PENUP NEWLINE
			;

cmd_pendown	:	KW_PENDOWN NEWLINE
			;

cmd_fd		:	KW_FD VAL_INT NEWLINE
			;

cmd_bd		:	KW_BD VAL_INT NEWLINE
			;

cmd_lt		:	KW_LT VAL_INT NEWLINE
			;

cmd_rt		:	KW_RT VAL_INT NEWLINE
			;

cmd_pencolor	:	KW_PENCOLOR VAL_HEXCOLOR NEWLINE
				;