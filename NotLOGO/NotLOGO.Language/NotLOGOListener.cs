using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotLOGO.Language
{
    public class NotLOGOListener : NotLOGOBaseListener
    {
		/// <summary>
		/// Enter a parse tree produced by <see cref="NotLOGOParser.cmd_penup"/>.
		/// <para>The default implementation does nothing.</para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		public override void EnterCmd_penup([NotNull] NotLOGOParser.Cmd_penupContext context) { }
		/// <summary>
		/// Exit a parse tree produced by <see cref="NotLOGOParser.cmd_penup"/>.
		/// <para>The default implementation does nothing.</para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		public override void ExitCmd_penup([NotNull] NotLOGOParser.Cmd_penupContext context) { }

		/// <summary>
		/// Enter a parse tree produced by <see cref="NotLOGOParser.cmd_pendown"/>.
		/// <para>The default implementation does nothing.</para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		public override void EnterCmd_pendown([NotNull] NotLOGOParser.Cmd_pendownContext context) { }
		/// <summary>
		/// Exit a parse tree produced by <see cref="NotLOGOParser.cmd_pendown"/>.
		/// <para>The default implementation does nothing.</para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		public override void ExitCmd_pendown([NotNull] NotLOGOParser.Cmd_pendownContext context) { }

		/// <summary>
		/// Enter a parse tree produced by <see cref="NotLOGOParser.cmd_fd"/>.
		/// <para>The default implementation does nothing.</para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		public override void EnterCmd_fd([NotNull] NotLOGOParser.Cmd_fdContext context) { }
		/// <summary>
		/// Exit a parse tree produced by <see cref="NotLOGOParser.cmd_fd"/>.
		/// <para>The default implementation does nothing.</para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		public override void ExitCmd_fd([NotNull] NotLOGOParser.Cmd_fdContext context) { }

		/// <summary>
		/// Enter a parse tree produced by <see cref="NotLOGOParser.cmd_bd"/>.
		/// <para>The default implementation does nothing.</para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		public override void EnterCmd_bd([NotNull] NotLOGOParser.Cmd_bdContext context) { }
		/// <summary>
		/// Exit a parse tree produced by <see cref="NotLOGOParser.cmd_bd"/>.
		/// <para>The default implementation does nothing.</para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		public override void ExitCmd_bd([NotNull] NotLOGOParser.Cmd_bdContext context) { }

		/// <summary>
		/// Enter a parse tree produced by <see cref="NotLOGOParser.cmd_lt"/>.
		/// <para>The default implementation does nothing.</para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		public override void EnterCmd_lt([NotNull] NotLOGOParser.Cmd_ltContext context) { }
		/// <summary>
		/// Exit a parse tree produced by <see cref="NotLOGOParser.cmd_lt"/>.
		/// <para>The default implementation does nothing.</para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		public override void ExitCmd_lt([NotNull] NotLOGOParser.Cmd_ltContext context) { }

		/// <summary>
		/// Enter a parse tree produced by <see cref="NotLOGOParser.cmd_rt"/>.
		/// <para>The default implementation does nothing.</para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		public override void EnterCmd_rt([NotNull] NotLOGOParser.Cmd_rtContext context) { }
		/// <summary>
		/// Exit a parse tree produced by <see cref="NotLOGOParser.cmd_rt"/>.
		/// <para>The default implementation does nothing.</para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		public override void ExitCmd_rt([NotNull] NotLOGOParser.Cmd_rtContext context) { }

		/// <summary>
		/// Enter a parse tree produced by <see cref="NotLOGOParser.cmd_pencolor"/>.
		/// <para>The default implementation does nothing.</para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		public override void EnterCmd_pencolor([NotNull] NotLOGOParser.Cmd_pencolorContext context) { }
		/// <summary>
		/// Exit a parse tree produced by <see cref="NotLOGOParser.cmd_pencolor"/>.
		/// <para>The default implementation does nothing.</para>
		/// </summary>
		/// <param name="context">The parse tree.</param>
		public override void ExitCmd_pencolor([NotNull] NotLOGOParser.Cmd_pencolorContext context) { }

		/// <inheritdoc/>
		/// <remarks>The default implementation does nothing.</remarks>
		public override void EnterEveryRule([NotNull] ParserRuleContext context) { }
		/// <inheritdoc/>
		/// <remarks>The default implementation does nothing.</remarks>
		public override void ExitEveryRule([NotNull] ParserRuleContext context) { }
		/// <inheritdoc/>
		/// <remarks>The default implementation does nothing.</remarks>
		public override void VisitTerminal([NotNull] ITerminalNode node) { }
		/// <inheritdoc/>
		/// <remarks>The default implementation does nothing.</remarks>
		public override void VisitErrorNode([NotNull] IErrorNode node) { }
	}
}
