//Generated by LateBindingApi.CodeGenerator
using System;
using LateBindingApi.Core;
namespace NetOffice.WordApi.Enums
{
	 /// <summary>
	 /// SupportByLibrary Word 9, 10, 11, 12, 14, 
	 /// </summary>
	[SupportByLibrary("Word", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum WdMailMergeDataSource
	{
		 /// <summary>
		 /// SupportByLibrary Word 9, 10, 11, 12, 14, 
		 /// </summary>
		 /// <remarks>-1</remarks>
		 [SupportByLibrary("Word", 9,10,11,12,14)]
		 wdNoMergeInfo = -1,

		 /// <summary>
		 /// SupportByLibrary Word 9, 10, 11, 12, 14, 
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByLibrary("Word", 9,10,11,12,14)]
		 wdMergeInfoFromWord = 0,

		 /// <summary>
		 /// SupportByLibrary Word 9, 10, 11, 12, 14, 
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByLibrary("Word", 9,10,11,12,14)]
		 wdMergeInfoFromAccessDDE = 1,

		 /// <summary>
		 /// SupportByLibrary Word 9, 10, 11, 12, 14, 
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByLibrary("Word", 9,10,11,12,14)]
		 wdMergeInfoFromExcelDDE = 2,

		 /// <summary>
		 /// SupportByLibrary Word 9, 10, 11, 12, 14, 
		 /// </summary>
		 /// <remarks>3</remarks>
		 [SupportByLibrary("Word", 9,10,11,12,14)]
		 wdMergeInfoFromMSQueryDDE = 3,

		 /// <summary>
		 /// SupportByLibrary Word 9, 10, 11, 12, 14, 
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByLibrary("Word", 9,10,11,12,14)]
		 wdMergeInfoFromODBC = 4,

		 /// <summary>
		 /// SupportByLibrary Word 10, 11, 12, 14, 
		 /// </summary>
		 /// <remarks>5</remarks>
		 [SupportByLibrary("Word", 10,11,12,14)]
		 wdMergeInfoFromODSO = 5
	}
}