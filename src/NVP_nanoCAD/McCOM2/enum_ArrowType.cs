using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace McCOM2.enum_ArrowType 
{


	[NVP_Manifest(
		Id = "B6AFCF74-E906-4E35-A508-5FB47D93B0F0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_ArrowType.enum_mcArrowUnknown", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_ArrowType", 
		NodeName = "enum_mcArrowUnknown", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcArrowUnknown : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.ArrowType.mcArrowUnknown);

		}
	}


	[NVP_Manifest(
		Id = "04C932EA-667C-430D-9A2A-DF7B1E922226", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_ArrowType.enum_mcArrowEmpty", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_ArrowType", 
		NodeName = "enum_mcArrowEmpty", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcArrowEmpty : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.ArrowType.mcArrowEmpty);

		}
	}


	[NVP_Manifest(
		Id = "F0A06EDD-EEED-447E-8506-165BBDA0882D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_ArrowType.enum_mcArrowFilled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_ArrowType", 
		NodeName = "enum_mcArrowFilled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcArrowFilled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.ArrowType.mcArrowFilled);

		}
	}


	[NVP_Manifest(
		Id = "BC3F4815-1325-41FB-AA04-3955E3F20C2B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_ArrowType.enum_mcArrowBlank", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_ArrowType", 
		NodeName = "enum_mcArrowBlank", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcArrowBlank : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.ArrowType.mcArrowBlank);

		}
	}


	[NVP_Manifest(
		Id = "0FA606A3-A190-4DF2-847A-FFAB025DC448", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_ArrowType.enum_mcArrowOpen", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_ArrowType", 
		NodeName = "enum_mcArrowOpen", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcArrowOpen : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.ArrowType.mcArrowOpen);

		}
	}


	[NVP_Manifest(
		Id = "26500A00-C49C-465F-A744-D4B3B4995A91", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_ArrowType.enum_mcArrowHalfUp", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_ArrowType", 
		NodeName = "enum_mcArrowHalfUp", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcArrowHalfUp : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.ArrowType.mcArrowHalfUp);

		}
	}


	[NVP_Manifest(
		Id = "9CEBED25-2901-4EE3-ADCD-C5C2E475E268", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_ArrowType.enum_mcArrowHalfDown", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_ArrowType", 
		NodeName = "enum_mcArrowHalfDown", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcArrowHalfDown : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.ArrowType.mcArrowHalfDown);

		}
	}


	[NVP_Manifest(
		Id = "8CFC0BBB-6067-4066-99A6-1D984C7820A8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_ArrowType.enum_mcArrowOpen90", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_ArrowType", 
		NodeName = "enum_mcArrowOpen90", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcArrowOpen90 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.ArrowType.mcArrowOpen90);

		}
	}


	[NVP_Manifest(
		Id = "589D0997-B89A-42CA-8A7D-54BFD6313183", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_ArrowType.enum_mcArrowDotFilled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_ArrowType", 
		NodeName = "enum_mcArrowDotFilled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcArrowDotFilled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.ArrowType.mcArrowDotFilled);

		}
	}


	[NVP_Manifest(
		Id = "A20DE34D-ED8F-4D3F-83F9-5C99FE91B984", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_ArrowType.enum_mcArrowDotBlank", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_ArrowType", 
		NodeName = "enum_mcArrowDotBlank", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcArrowDotBlank : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.ArrowType.mcArrowDotBlank);

		}
	}


	[NVP_Manifest(
		Id = "5505E552-B8A4-4E50-9A80-815F19561C77", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_ArrowType.enum_mcArrowSlash", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_ArrowType", 
		NodeName = "enum_mcArrowSlash", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcArrowSlash : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.ArrowType.mcArrowSlash);

		}
	}


	[NVP_Manifest(
		Id = "4A0E7FEE-C683-4952-9B25-A6957A60615A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_ArrowType.enum_mcArrowDatumFilled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_ArrowType", 
		NodeName = "enum_mcArrowDatumFilled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcArrowDatumFilled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.ArrowType.mcArrowDatumFilled);

		}
	}


	[NVP_Manifest(
		Id = "614DBA54-761E-4418-92B6-A4240995FD7A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "McCOM2.enum_ArrowType.enum_mcArrowDatumBlank", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.McCOM2.enum_ArrowType", 
		NodeName = "enum_mcArrowDatumBlank", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_mcArrowDatumBlank : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(McCOM2.ArrowType.mcArrowDatumBlank);

		}
	}
}
