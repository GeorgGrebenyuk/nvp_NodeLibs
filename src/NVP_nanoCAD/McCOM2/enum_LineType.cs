using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace McCOM2.enum_LineType 
{


	[NVP_Manifest(
		Id = "65226847-6EB1-44D5-B8DB-E5ADC980DD67", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_LineType.enum_mcLinetypeByBlock", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_LineType", 
		NodeName = "enum_mcLinetypeByBlock", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcLinetypeByBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.LineType.mcLinetypeByBlock);

		}
	}


	[NVP_Manifest(
		Id = "E907C90A-5E88-430F-9BD8-499218CF846F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_LineType.enum_mcLinetypeByLayer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_LineType", 
		NodeName = "enum_mcLinetypeByLayer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcLinetypeByLayer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.LineType.mcLinetypeByLayer);

		}
	}


	[NVP_Manifest(
		Id = "410585D6-AEF3-4B19-87B8-BE7DF3A3F0CE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_LineType.enum_mcLinetypeMainBold", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_LineType", 
		NodeName = "enum_mcLinetypeMainBold", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcLinetypeMainBold : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.LineType.mcLinetypeMainBold);

		}
	}


	[NVP_Manifest(
		Id = "A4847981-F520-43CD-BAAC-25A2F1BB8F10", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_LineType.enum_mcLinetypeMainThin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_LineType", 
		NodeName = "enum_mcLinetypeMainThin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcLinetypeMainThin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.LineType.mcLinetypeMainThin);

		}
	}


	[NVP_Manifest(
		Id = "D2D5E549-B25B-476B-AD1D-18DB9745F8A0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_LineType.enum_mcLinetypeWaveThin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_LineType", 
		NodeName = "enum_mcLinetypeWaveThin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcLinetypeWaveThin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.LineType.mcLinetypeWaveThin);

		}
	}


	[NVP_Manifest(
		Id = "8F72ABBA-5076-46CB-8C1D-EA10C4132517", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_LineType.enum_mcLinetypeDashThin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_LineType", 
		NodeName = "enum_mcLinetypeDashThin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcLinetypeDashThin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.LineType.mcLinetypeDashThin);

		}
	}


	[NVP_Manifest(
		Id = "C34739CE-AE60-4B88-9B2E-E935D00B08DC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_LineType.enum_mcLinetypeDashDotThin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_LineType", 
		NodeName = "enum_mcLinetypeDashDotThin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcLinetypeDashDotThin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.LineType.mcLinetypeDashDotThin);

		}
	}


	[NVP_Manifest(
		Id = "6C116C89-0172-4203-A325-1017BB7E68FE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_LineType.enum_mcLinetypeDashDotBold", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_LineType", 
		NodeName = "enum_mcLinetypeDashDotBold", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcLinetypeDashDotBold : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.LineType.mcLinetypeDashDotBold);

		}
	}


	[NVP_Manifest(
		Id = "8AB2C18D-E0E8-4B66-BD54-B2E895BEBB3E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_LineType.enum_mcLinetypeBrokenBold", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_LineType", 
		NodeName = "enum_mcLinetypeBrokenBold", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcLinetypeBrokenBold : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.LineType.mcLinetypeBrokenBold);

		}
	}


	[NVP_Manifest(
		Id = "7E884993-5837-43F5-8496-4E1CD7C69D33", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_LineType.enum_mcLinetypeZigzagThin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_LineType", 
		NodeName = "enum_mcLinetypeZigzagThin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcLinetypeZigzagThin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.LineType.mcLinetypeZigzagThin);

		}
	}


	[NVP_Manifest(
		Id = "0055891D-BF4F-4290-A227-641323E4B8E2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_LineType.enum_mcLinetypeDashDotDotThin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_LineType", 
		NodeName = "enum_mcLinetypeDashDotDotThin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcLinetypeDashDotDotThin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.LineType.mcLinetypeDashDotDotThin);

		}
	}
}
