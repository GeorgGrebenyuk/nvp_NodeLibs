using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcDimArrowheadType 
{


	[NVP_Manifest(
		Id = "5F367947-12BE-4C03-B755-46D4F4631791", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimArrowheadType.enum_acArrowDefault", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimArrowheadType", 
		NodeName = "enum_acArrowDefault", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acArrowDefault : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimArrowheadType.acArrowDefault);

		}
	}


	[NVP_Manifest(
		Id = "ACE36E95-6F85-4D4F-A865-D331D571EC9A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimArrowheadType.enum_acArrowClosedBlank", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimArrowheadType", 
		NodeName = "enum_acArrowClosedBlank", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acArrowClosedBlank : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimArrowheadType.acArrowClosedBlank);

		}
	}


	[NVP_Manifest(
		Id = "4D3DE63F-6B37-4D31-BE73-1EB4528BEE5F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimArrowheadType.enum_acArrowClosed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimArrowheadType", 
		NodeName = "enum_acArrowClosed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acArrowClosed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimArrowheadType.acArrowClosed);

		}
	}


	[NVP_Manifest(
		Id = "6C9F6826-7A76-41B3-B407-3FD3FC3F3ECA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimArrowheadType.enum_acArrowDot", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimArrowheadType", 
		NodeName = "enum_acArrowDot", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acArrowDot : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimArrowheadType.acArrowDot);

		}
	}


	[NVP_Manifest(
		Id = "21429718-9E7E-4C09-8C7E-2EEADF1A1060", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimArrowheadType.enum_acArrowArchTick", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimArrowheadType", 
		NodeName = "enum_acArrowArchTick", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acArrowArchTick : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimArrowheadType.acArrowArchTick);

		}
	}


	[NVP_Manifest(
		Id = "568CA516-98AB-4DCD-BD3D-6FACBE96C8A6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimArrowheadType.enum_acArrowOblique", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimArrowheadType", 
		NodeName = "enum_acArrowOblique", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acArrowOblique : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimArrowheadType.acArrowOblique);

		}
	}


	[NVP_Manifest(
		Id = "24C7B3D2-3F43-4CC2-9B2C-A06EE0EDB395", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimArrowheadType.enum_acArrowOpen", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimArrowheadType", 
		NodeName = "enum_acArrowOpen", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acArrowOpen : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimArrowheadType.acArrowOpen);

		}
	}


	[NVP_Manifest(
		Id = "64755D92-EA4B-4A0D-A46F-3E5C3DFDE45B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimArrowheadType.enum_acArrowOrigin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimArrowheadType", 
		NodeName = "enum_acArrowOrigin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acArrowOrigin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimArrowheadType.acArrowOrigin);

		}
	}


	[NVP_Manifest(
		Id = "D7625D8B-6784-497D-9690-3CF0612429A6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimArrowheadType.enum_acArrowOrigin2", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimArrowheadType", 
		NodeName = "enum_acArrowOrigin2", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acArrowOrigin2 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimArrowheadType.acArrowOrigin2);

		}
	}


	[NVP_Manifest(
		Id = "2636EEC7-9279-4F5B-862F-5AD83882C4BB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimArrowheadType.enum_acArrowOpen90", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimArrowheadType", 
		NodeName = "enum_acArrowOpen90", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acArrowOpen90 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimArrowheadType.acArrowOpen90);

		}
	}


	[NVP_Manifest(
		Id = "698461B0-3929-458B-8B82-CA3EB7DD093A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimArrowheadType.enum_acArrowOpen30", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimArrowheadType", 
		NodeName = "enum_acArrowOpen30", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acArrowOpen30 : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimArrowheadType.acArrowOpen30);

		}
	}


	[NVP_Manifest(
		Id = "6E52926F-A7FB-46F0-88AC-90D792CA3DE6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimArrowheadType.enum_acArrowDotSmall", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimArrowheadType", 
		NodeName = "enum_acArrowDotSmall", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acArrowDotSmall : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimArrowheadType.acArrowDotSmall);

		}
	}


	[NVP_Manifest(
		Id = "E6909FBF-6E44-4ED8-A327-764D2FAF10C1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimArrowheadType.enum_acArrowDotBlank", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimArrowheadType", 
		NodeName = "enum_acArrowDotBlank", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acArrowDotBlank : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimArrowheadType.acArrowDotBlank);

		}
	}


	[NVP_Manifest(
		Id = "23D3D005-0D7F-4E38-9D94-3BE5D913B05A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimArrowheadType.enum_acArrowSmall", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimArrowheadType", 
		NodeName = "enum_acArrowSmall", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acArrowSmall : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimArrowheadType.acArrowSmall);

		}
	}


	[NVP_Manifest(
		Id = "58CF2F44-ABE6-439A-9B6C-943BD2C604BA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimArrowheadType.enum_acArrowBoxBlank", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimArrowheadType", 
		NodeName = "enum_acArrowBoxBlank", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acArrowBoxBlank : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimArrowheadType.acArrowBoxBlank);

		}
	}


	[NVP_Manifest(
		Id = "C8411B8F-4EE6-4E6C-B446-7A01BAD717E6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimArrowheadType.enum_acArrowBoxFilled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimArrowheadType", 
		NodeName = "enum_acArrowBoxFilled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acArrowBoxFilled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimArrowheadType.acArrowBoxFilled);

		}
	}


	[NVP_Manifest(
		Id = "9E1FFA63-31FB-41C2-A89A-65F1468A0C71", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimArrowheadType.enum_acArrowDatumBlank", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimArrowheadType", 
		NodeName = "enum_acArrowDatumBlank", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acArrowDatumBlank : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimArrowheadType.acArrowDatumBlank);

		}
	}


	[NVP_Manifest(
		Id = "3A405886-6D47-4C7E-B711-A662DC1ABB7E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimArrowheadType.enum_acArrowDatumFilled", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimArrowheadType", 
		NodeName = "enum_acArrowDatumFilled", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acArrowDatumFilled : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimArrowheadType.acArrowDatumFilled);

		}
	}


	[NVP_Manifest(
		Id = "F89737DE-C816-4664-834C-EB53E73A9A37", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimArrowheadType.enum_acArrowIntegral", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimArrowheadType", 
		NodeName = "enum_acArrowIntegral", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acArrowIntegral : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimArrowheadType.acArrowIntegral);

		}
	}


	[NVP_Manifest(
		Id = "077368F0-4460-407F-BF11-F87D59482726", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimArrowheadType.enum_acArrowNone", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimArrowheadType", 
		NodeName = "enum_acArrowNone", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acArrowNone : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimArrowheadType.acArrowNone);

		}
	}


	[NVP_Manifest(
		Id = "508416E2-D278-4308-BC20-7FF5997528F4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcDimArrowheadType.enum_acArrowUserDefined", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcDimArrowheadType", 
		NodeName = "enum_acArrowUserDefined", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acArrowUserDefined : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcDimArrowheadType.acArrowUserDefined);

		}
	}
}
