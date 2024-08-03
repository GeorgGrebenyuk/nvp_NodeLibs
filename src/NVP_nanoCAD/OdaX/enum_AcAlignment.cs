using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcAlignment 
{


	[NVP_Manifest(
		Id = "E4993144-8FD0-44B0-A47D-BC973FF3560D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcAlignment.enum_acAlignmentLeft", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcAlignment", 
		NodeName = "enum_acAlignmentLeft", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acAlignmentLeft : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcAlignment.acAlignmentLeft);

		}
	}


	[NVP_Manifest(
		Id = "9C45C9B4-CF55-49B3-8EED-A751AB0248AD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcAlignment.enum_acAlignmentCenter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcAlignment", 
		NodeName = "enum_acAlignmentCenter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acAlignmentCenter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcAlignment.acAlignmentCenter);

		}
	}


	[NVP_Manifest(
		Id = "82F390D9-1AAE-4C92-9A82-CEF19DB6F492", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcAlignment.enum_acAlignmentRight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcAlignment", 
		NodeName = "enum_acAlignmentRight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acAlignmentRight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcAlignment.acAlignmentRight);

		}
	}


	[NVP_Manifest(
		Id = "C90789CA-CCFC-40B7-ABF2-58E3EA0DD078", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcAlignment.enum_acAlignmentAligned", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcAlignment", 
		NodeName = "enum_acAlignmentAligned", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acAlignmentAligned : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcAlignment.acAlignmentAligned);

		}
	}


	[NVP_Manifest(
		Id = "97D2CF6D-BC47-4527-B058-0DC22BA18680", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcAlignment.enum_acAlignmentMiddle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcAlignment", 
		NodeName = "enum_acAlignmentMiddle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acAlignmentMiddle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcAlignment.acAlignmentMiddle);

		}
	}


	[NVP_Manifest(
		Id = "68077236-E3D3-4E75-BF05-E92570A59561", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcAlignment.enum_acAlignmentFit", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcAlignment", 
		NodeName = "enum_acAlignmentFit", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acAlignmentFit : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcAlignment.acAlignmentFit);

		}
	}


	[NVP_Manifest(
		Id = "B32CF6CC-CB89-4742-A432-54DBED8AFCA9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcAlignment.enum_acAlignmentTopLeft", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcAlignment", 
		NodeName = "enum_acAlignmentTopLeft", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acAlignmentTopLeft : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcAlignment.acAlignmentTopLeft);

		}
	}


	[NVP_Manifest(
		Id = "38A758D1-A91D-44F2-A1B3-82D3B053DC15", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcAlignment.enum_acAlignmentTopCenter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcAlignment", 
		NodeName = "enum_acAlignmentTopCenter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acAlignmentTopCenter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcAlignment.acAlignmentTopCenter);

		}
	}


	[NVP_Manifest(
		Id = "50461775-FF52-4D26-86B2-FDF7582CFB34", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcAlignment.enum_acAlignmentTopRight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcAlignment", 
		NodeName = "enum_acAlignmentTopRight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acAlignmentTopRight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcAlignment.acAlignmentTopRight);

		}
	}


	[NVP_Manifest(
		Id = "C3055788-06C4-4143-AEBA-CB026EA84D46", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcAlignment.enum_acAlignmentMiddleLeft", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcAlignment", 
		NodeName = "enum_acAlignmentMiddleLeft", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acAlignmentMiddleLeft : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcAlignment.acAlignmentMiddleLeft);

		}
	}


	[NVP_Manifest(
		Id = "4684F21D-6ADE-444F-90DE-72C776803830", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcAlignment.enum_acAlignmentMiddleCenter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcAlignment", 
		NodeName = "enum_acAlignmentMiddleCenter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acAlignmentMiddleCenter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcAlignment.acAlignmentMiddleCenter);

		}
	}


	[NVP_Manifest(
		Id = "3624A258-5006-4D28-A318-6795DB7B996E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcAlignment.enum_acAlignmentMiddleRight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcAlignment", 
		NodeName = "enum_acAlignmentMiddleRight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acAlignmentMiddleRight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcAlignment.acAlignmentMiddleRight);

		}
	}


	[NVP_Manifest(
		Id = "BC6FD947-706E-4E4A-BB69-91456980C3D8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcAlignment.enum_acAlignmentBottomLeft", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcAlignment", 
		NodeName = "enum_acAlignmentBottomLeft", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acAlignmentBottomLeft : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcAlignment.acAlignmentBottomLeft);

		}
	}


	[NVP_Manifest(
		Id = "79EAAF8A-805D-4CB7-8EFD-499324499B3C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcAlignment.enum_acAlignmentBottomCenter", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcAlignment", 
		NodeName = "enum_acAlignmentBottomCenter", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acAlignmentBottomCenter : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcAlignment.acAlignmentBottomCenter);

		}
	}


	[NVP_Manifest(
		Id = "1771946B-F5F8-4E0F-8A13-202A8704B62E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcAlignment.enum_acAlignmentBottomRight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcAlignment", 
		NodeName = "enum_acAlignmentBottomRight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acAlignmentBottomRight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcAlignment.acAlignmentBottomRight);

		}
	}
}
