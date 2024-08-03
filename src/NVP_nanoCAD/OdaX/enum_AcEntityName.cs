using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcEntityName 
{


	[NVP_Manifest(
		Id = "0CD605FF-C54D-4592-9695-8037A7A1DFDD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_ac3dFace", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_ac3dFace", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_ac3dFace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.ac3dFace);

		}
	}


	[NVP_Manifest(
		Id = "E49E5A7A-FC7E-412E-BCB8-CBCF7C09E802", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_ac3dPolyline", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_ac3dPolyline", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_ac3dPolyline : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.ac3dPolyline);

		}
	}


	[NVP_Manifest(
		Id = "CBF52554-A73D-45A4-B3F2-6549E4057E5F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_ac3dSolid", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_ac3dSolid", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_ac3dSolid : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.ac3dSolid);

		}
	}


	[NVP_Manifest(
		Id = "9E490512-A3A0-43BF-A69E-CBCDE07314A2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acArc", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acArc", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acArc : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acArc);

		}
	}


	[NVP_Manifest(
		Id = "3C39748A-1826-4D55-837D-634248DD9ED4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acAttribute", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acAttribute", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acAttribute : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acAttribute);

		}
	}


	[NVP_Manifest(
		Id = "19B2C44D-D78B-4AC2-A2FC-1A6B6649396B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acAttributeReference", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acAttributeReference", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acAttributeReference : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acAttributeReference);

		}
	}


	[NVP_Manifest(
		Id = "4724AFA1-47BD-4353-B8CA-091CF0E6EF61", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acBlockReference", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acBlockReference", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acBlockReference : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acBlockReference);

		}
	}


	[NVP_Manifest(
		Id = "F77D4ABA-EFCF-42CB-83F8-25082899CDC1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acCircle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acCircle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acCircle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acCircle);

		}
	}


	[NVP_Manifest(
		Id = "11D2772B-C747-4692-AA89-51868693E30F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acDimAligned", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acDimAligned", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDimAligned : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acDimAligned);

		}
	}


	[NVP_Manifest(
		Id = "EEA387F9-439E-4A3C-976A-17DB02CBBA2D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acDimAngular", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acDimAngular", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDimAngular : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acDimAngular);

		}
	}


	[NVP_Manifest(
		Id = "14E5C162-A9B5-46C5-84D7-C5F0D7CD1B85", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acDimDiametric", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acDimDiametric", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDimDiametric : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acDimDiametric);

		}
	}


	[NVP_Manifest(
		Id = "637B5669-1A9F-4F19-9E45-AAAC13328597", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acDimOrdinate", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acDimOrdinate", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDimOrdinate : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acDimOrdinate);

		}
	}


	[NVP_Manifest(
		Id = "00B6D8FB-6B91-46EA-8DEA-CC504AFACC56", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acDimRadial", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acDimRadial", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDimRadial : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acDimRadial);

		}
	}


	[NVP_Manifest(
		Id = "4DC13E52-B43C-42DE-BF09-09D3E4FF3EB2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acDimRotated", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acDimRotated", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDimRotated : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acDimRotated);

		}
	}


	[NVP_Manifest(
		Id = "5B9FED6A-089D-4301-966F-0DFB67BE487A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acEllipse", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acEllipse", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acEllipse : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acEllipse);

		}
	}


	[NVP_Manifest(
		Id = "8B003E29-C858-4D7F-9F15-AED1D0BEF9AD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acHatch", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acHatch", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHatch : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acHatch);

		}
	}


	[NVP_Manifest(
		Id = "D9A91035-B16C-49C8-BD5D-7CD75A87C959", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acLeader", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acLeader", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acLeader : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acLeader);

		}
	}


	[NVP_Manifest(
		Id = "F97470C6-CCA0-4A78-BA50-44245FFA7938", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acLine", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acLine", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acLine);

		}
	}


	[NVP_Manifest(
		Id = "70CAF0ED-870B-4409-81F4-C01B196F34BF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acMtext", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acMtext", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acMtext : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acMtext);

		}
	}


	[NVP_Manifest(
		Id = "02586177-C560-40F0-8C9E-667B28F88DF0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acPoint);

		}
	}


	[NVP_Manifest(
		Id = "5545B41C-79D2-43F9-BF36-7BABE38AB033", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acPolyline", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acPolyline", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acPolyline : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acPolyline);

		}
	}


	[NVP_Manifest(
		Id = "EC259C1E-3A39-4BAD-92FE-B6786EE6E97F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acPolylineLight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acPolylineLight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acPolylineLight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acPolylineLight);

		}
	}


	[NVP_Manifest(
		Id = "D2F82438-3B03-4C38-8FDE-B7D706CAED0B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acPolymesh", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acPolymesh", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acPolymesh : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acPolymesh);

		}
	}


	[NVP_Manifest(
		Id = "41B34311-8829-48F3-A89E-16F58DDCF0EE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acRaster", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acRaster", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acRaster : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acRaster);

		}
	}


	[NVP_Manifest(
		Id = "1E1B9FF2-796F-4455-BE3E-852284BD03E8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acRay", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acRay", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acRay : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acRay);

		}
	}


	[NVP_Manifest(
		Id = "56AEE130-CADF-46FB-B554-989B682E1158", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acRegion", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acRegion", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acRegion : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acRegion);

		}
	}


	[NVP_Manifest(
		Id = "43F249D8-60FF-414E-A8CD-F98A74265935", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acShape", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acShape", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acShape : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acShape);

		}
	}


	[NVP_Manifest(
		Id = "50EF7648-6F5C-427A-AD6E-5B0FDB4EFA55", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acSolid", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acSolid", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSolid : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acSolid);

		}
	}


	[NVP_Manifest(
		Id = "B0197098-93E7-4BA6-BA7D-92F580EA8CC4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acSpline", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acSpline", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSpline : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acSpline);

		}
	}


	[NVP_Manifest(
		Id = "A033652B-8CF6-45DA-AF87-4A7DD62B416C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acText", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acText", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acText : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acText);

		}
	}


	[NVP_Manifest(
		Id = "E440B892-1F6E-4B44-8A64-448662975B16", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acTolerance", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acTolerance", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTolerance : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acTolerance);

		}
	}


	[NVP_Manifest(
		Id = "79F09E35-E2D0-4D79-8BE3-975573D9830F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acTrace", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acTrace", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTrace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acTrace);

		}
	}


	[NVP_Manifest(
		Id = "AD4A3D25-1DCB-47F3-B5CE-CC9E21A2743D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acPViewport", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acPViewport", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acPViewport : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acPViewport);

		}
	}


	[NVP_Manifest(
		Id = "025432B1-3A7B-443E-BD57-AC206AE2B955", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acXline", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acXline", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acXline : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acXline);

		}
	}


	[NVP_Manifest(
		Id = "01373C3F-FED0-4874-8CDC-35FEB3DA45CC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acGroup", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acGroup", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acGroup : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acGroup);

		}
	}


	[NVP_Manifest(
		Id = "E8BB5474-9DEE-435C-AD4F-F8C99455719C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acMInsertBlock", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acMInsertBlock", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acMInsertBlock : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acMInsertBlock);

		}
	}


	[NVP_Manifest(
		Id = "CFD1C936-C1A3-4018-A27E-6DA5BF300FD2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acPolyfaceMesh", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acPolyfaceMesh", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acPolyfaceMesh : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acPolyfaceMesh);

		}
	}


	[NVP_Manifest(
		Id = "3A482DF6-BC27-4DDB-B7D7-6746057CE038", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acMLine", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acMLine", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acMLine : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acMLine);

		}
	}


	[NVP_Manifest(
		Id = "161062DB-1843-4913-B860-9D4CE8771325", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acDim3PointAngular", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acDim3PointAngular", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDim3PointAngular : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acDim3PointAngular);

		}
	}


	[NVP_Manifest(
		Id = "03B8B9B9-D2E4-4416-AECC-5C3E56C2BFB4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acExternalReference", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acExternalReference", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acExternalReference : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acExternalReference);

		}
	}


	[NVP_Manifest(
		Id = "65B75E86-5BA6-459D-90F2-A507D96E4890", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acTable", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acTable", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acTable);

		}
	}


	[NVP_Manifest(
		Id = "3C928F7B-51F5-4675-9EAD-0FF275DA0627", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acDimArcLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acDimArcLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDimArcLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acDimArcLength);

		}
	}


	[NVP_Manifest(
		Id = "BF06D484-5BE6-4CEC-B5BD-050063AF4A27", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acDimRadialLarge", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acDimRadialLarge", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDimRadialLarge : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acDimRadialLarge);

		}
	}


	[NVP_Manifest(
		Id = "3E1C179B-1741-42E0-B25A-7F89A54AB858", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acDwfUnderlay", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acDwfUnderlay", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDwfUnderlay : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acDwfUnderlay);

		}
	}


	[NVP_Manifest(
		Id = "6B1B2F58-CEED-4B43-8DD6-CC16F529D683", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acDgnUnderlay", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acDgnUnderlay", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDgnUnderlay : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acDgnUnderlay);

		}
	}


	[NVP_Manifest(
		Id = "F12B9CA4-2A8D-414F-AF3C-B954D304C4EB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acMLeader", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acMLeader", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acMLeader : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acMLeader);

		}
	}


	[NVP_Manifest(
		Id = "B016EC1D-C436-4B6D-8D0A-2F54C203F4F8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acSubDMesh", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acSubDMesh", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acSubDMesh : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acSubDMesh);

		}
	}


	[NVP_Manifest(
		Id = "68CA7EE0-4752-4042-8901-100F37F740DF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcEntityName.enum_acPdfUnderlay", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcEntityName", 
		NodeName = "enum_acPdfUnderlay", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acPdfUnderlay : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcEntityName.acPdfUnderlay);

		}
	}
}
