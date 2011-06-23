//Generated by LateBindingApi.CodeGenerator
using System;
using LateBindingApi.Core;
namespace NetOffice.ADODBApi.Enums
{
	 /// <summary>
	 /// SupportByLibrary ADODB 2.1, 2.5, 
	 /// </summary>
	[SupportByLibrary("ADODB", 2.1,2.5)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum IsolationLevelEnum
	{
		 /// <summary>
		 /// SupportByLibrary ADODB 2.1, 2.5, 
		 /// </summary>
		 /// <remarks>-1</remarks>
		 [SupportByLibrary("ADODB", 2.1,2.5)]
		 adXactUnspecified = -1,

		 /// <summary>
		 /// SupportByLibrary ADODB 2.1, 2.5, 
		 /// </summary>
		 /// <remarks>16</remarks>
		 [SupportByLibrary("ADODB", 2.1,2.5)]
		 adXactChaos = 16,

		 /// <summary>
		 /// SupportByLibrary ADODB 2.1, 2.5, 
		 /// </summary>
		 /// <remarks>256</remarks>
		 [SupportByLibrary("ADODB", 2.1,2.5)]
		 adXactReadUncommitted = 256,

		 /// <summary>
		 /// SupportByLibrary ADODB 2.1, 2.5, 
		 /// </summary>
		 /// <remarks>256</remarks>
		 [SupportByLibrary("ADODB", 2.1,2.5)]
		 adXactBrowse = 256,

		 /// <summary>
		 /// SupportByLibrary ADODB 2.1, 2.5, 
		 /// </summary>
		 /// <remarks>4096</remarks>
		 [SupportByLibrary("ADODB", 2.1,2.5)]
		 adXactCursorStability = 4096,

		 /// <summary>
		 /// SupportByLibrary ADODB 2.1, 2.5, 
		 /// </summary>
		 /// <remarks>4096</remarks>
		 [SupportByLibrary("ADODB", 2.1,2.5)]
		 adXactReadCommitted = 4096,

		 /// <summary>
		 /// SupportByLibrary ADODB 2.1, 2.5, 
		 /// </summary>
		 /// <remarks>65536</remarks>
		 [SupportByLibrary("ADODB", 2.1,2.5)]
		 adXactRepeatableRead = 65536,

		 /// <summary>
		 /// SupportByLibrary ADODB 2.1, 2.5, 
		 /// </summary>
		 /// <remarks>1048576</remarks>
		 [SupportByLibrary("ADODB", 2.1,2.5)]
		 adXactSerializable = 1048576,

		 /// <summary>
		 /// SupportByLibrary ADODB 2.1, 2.5, 
		 /// </summary>
		 /// <remarks>1048576</remarks>
		 [SupportByLibrary("ADODB", 2.1,2.5)]
		 adXactIsolated = 1048576
	}
}