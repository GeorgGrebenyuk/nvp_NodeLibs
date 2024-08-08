using NVP.API.Nodes;
using System;
using System.Collections.Generic;

using NVP_Manifest_Creator;

///<summary>
///
///</summary>
namespace OdaX.enum_AcTableStyleOverrides 
{


	[NVP_Manifest(
		Id = "A7547EF7-7E71-49F9-97F9-F71CA5D50B4E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acTitleSuppressed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acTitleSuppressed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTitleSuppressed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acTitleSuppressed);

		}
	}


	[NVP_Manifest(
		Id = "A18583D0-E31C-47B5-B86B-C9568B51FE05", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acHeaderSuppressed", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acHeaderSuppressed", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHeaderSuppressed : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acHeaderSuppressed);

		}
	}


	[NVP_Manifest(
		Id = "3EAFF98A-3205-4C3E-8CA9-AD945218A64D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acFlowDirection", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acFlowDirection", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acFlowDirection : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acFlowDirection);

		}
	}


	[NVP_Manifest(
		Id = "B336D11A-DAD2-4B9E-8C36-F36D5FA47560", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acHorzCellMargin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acHorzCellMargin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHorzCellMargin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acHorzCellMargin);

		}
	}


	[NVP_Manifest(
		Id = "197137EB-70C8-47D4-8746-C8E906B2C11B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acVertCellMargin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acVertCellMargin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acVertCellMargin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acVertCellMargin);

		}
	}


	[NVP_Manifest(
		Id = "A0E6675B-3A7A-431A-AE3C-AAF5B2173ACB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acTitleRowColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acTitleRowColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTitleRowColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acTitleRowColor);

		}
	}


	[NVP_Manifest(
		Id = "4A027054-96D8-408B-AAA0-5FD020039B3D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acHeaderRowColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acHeaderRowColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHeaderRowColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acHeaderRowColor);

		}
	}


	[NVP_Manifest(
		Id = "51C76669-FB24-4793-AC3C-9786C689F737", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acDataRowColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acDataRowColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDataRowColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acDataRowColor);

		}
	}


	[NVP_Manifest(
		Id = "532971A8-B419-41BF-B6F9-19AC7C80A073", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acTitleRowFillNone", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acTitleRowFillNone", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTitleRowFillNone : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acTitleRowFillNone);

		}
	}


	[NVP_Manifest(
		Id = "B0AF5EC4-52F0-42C9-A946-244B54F03C75", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acHeaderRowFillNone", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acHeaderRowFillNone", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHeaderRowFillNone : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acHeaderRowFillNone);

		}
	}


	[NVP_Manifest(
		Id = "36112B57-192C-43CB-A514-24CB98456E76", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acDataRowFillNone", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acDataRowFillNone", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDataRowFillNone : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acDataRowFillNone);

		}
	}


	[NVP_Manifest(
		Id = "FEB4932C-9FFB-4BCD-8F4B-D1F8D25E00BA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acTitleRowFillColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acTitleRowFillColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTitleRowFillColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acTitleRowFillColor);

		}
	}


	[NVP_Manifest(
		Id = "1FE713D2-5807-44C9-99AA-BC1DCEADCF0C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acHeaderRowFillColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acHeaderRowFillColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHeaderRowFillColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acHeaderRowFillColor);

		}
	}


	[NVP_Manifest(
		Id = "56EAF470-38DC-4CE0-835F-90D62DA424E7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acDataRowFillColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acDataRowFillColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDataRowFillColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acDataRowFillColor);

		}
	}


	[NVP_Manifest(
		Id = "791CD47F-4925-4DCE-9629-72EFBECBB61F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acTitleRowAlignment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acTitleRowAlignment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTitleRowAlignment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acTitleRowAlignment);

		}
	}


	[NVP_Manifest(
		Id = "FA17685C-8EF8-4DBA-A647-DA76321F43E7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acHeaderRowAlignment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acHeaderRowAlignment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHeaderRowAlignment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acHeaderRowAlignment);

		}
	}


	[NVP_Manifest(
		Id = "53292DBC-90F5-4653-B676-173431BCBCC5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acDataRowAlignment", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acDataRowAlignment", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDataRowAlignment : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acDataRowAlignment);

		}
	}


	[NVP_Manifest(
		Id = "AF5C8FF3-922B-4A3A-A3B2-B473521916D7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acTitleRowTextStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acTitleRowTextStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTitleRowTextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acTitleRowTextStyle);

		}
	}


	[NVP_Manifest(
		Id = "1B507DD1-71D1-426D-8DEC-D2C8AC18900B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acHeaderRowTextStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acHeaderRowTextStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHeaderRowTextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acHeaderRowTextStyle);

		}
	}


	[NVP_Manifest(
		Id = "7B96E15F-22A7-422F-B08E-C2D85EEE9FEB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acDataRowTextStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acDataRowTextStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDataRowTextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acDataRowTextStyle);

		}
	}


	[NVP_Manifest(
		Id = "236EA1C2-CECA-463E-BC90-8C1873393C7F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acTitleRowTextHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acTitleRowTextHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTitleRowTextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acTitleRowTextHeight);

		}
	}


	[NVP_Manifest(
		Id = "007EBCBA-E04B-420B-BE9F-3089AAE959EE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acHeaderRowTextHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acHeaderRowTextHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHeaderRowTextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acHeaderRowTextHeight);

		}
	}


	[NVP_Manifest(
		Id = "B30DB076-CEC1-4011-B912-B6DD1794E384", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acDataRowTextHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acDataRowTextHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDataRowTextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acDataRowTextHeight);

		}
	}


	[NVP_Manifest(
		Id = "F45FD460-0923-4DE6-92D4-4126C6DF3F09", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acTitleRowDataType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acTitleRowDataType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTitleRowDataType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acTitleRowDataType);

		}
	}


	[NVP_Manifest(
		Id = "632E26A5-F913-4F16-B3B9-C26ED65613A4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acHeaderRowDataType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acHeaderRowDataType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHeaderRowDataType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acHeaderRowDataType);

		}
	}


	[NVP_Manifest(
		Id = "E1482590-2A73-4E9B-AA14-02C581E3BF18", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acDataRowDataType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acDataRowDataType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDataRowDataType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acDataRowDataType);

		}
	}


	[NVP_Manifest(
		Id = "130CEA74-5F15-4CA2-BC4B-DB8D1B7DF342", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acTitleHorzTopColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acTitleHorzTopColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTitleHorzTopColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acTitleHorzTopColor);

		}
	}


	[NVP_Manifest(
		Id = "736E347C-7FCE-4767-94C7-D6136F6FC62D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acTitleHorzInsideColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acTitleHorzInsideColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTitleHorzInsideColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acTitleHorzInsideColor);

		}
	}


	[NVP_Manifest(
		Id = "813F91F9-E78C-4BA5-A35C-3F5D549A3C23", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acTitleHorzBottomColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acTitleHorzBottomColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTitleHorzBottomColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acTitleHorzBottomColor);

		}
	}


	[NVP_Manifest(
		Id = "102FD538-A4FE-435E-8FE5-8BC92B0D9C3A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acTitleVertLeftColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acTitleVertLeftColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTitleVertLeftColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acTitleVertLeftColor);

		}
	}


	[NVP_Manifest(
		Id = "70E7DB6D-5C03-4AC1-BF68-9A756982F1DA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acTitleVertInsideColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acTitleVertInsideColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTitleVertInsideColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acTitleVertInsideColor);

		}
	}


	[NVP_Manifest(
		Id = "3DA3ABA9-1A4D-4BC3-8DCE-D39ECE379089", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acTitleVertRightColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acTitleVertRightColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTitleVertRightColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acTitleVertRightColor);

		}
	}


	[NVP_Manifest(
		Id = "BA1EEF49-FAB6-4464-BA1D-A95D7C0A7557", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acHeaderHorzTopColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acHeaderHorzTopColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHeaderHorzTopColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acHeaderHorzTopColor);

		}
	}


	[NVP_Manifest(
		Id = "1A24ABE2-76C7-4698-A9AC-E90A0AB2ED73", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acHeaderHorzInsideColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acHeaderHorzInsideColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHeaderHorzInsideColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acHeaderHorzInsideColor);

		}
	}


	[NVP_Manifest(
		Id = "7B494A9B-DDB2-4CF6-8D66-7DAFEB842555", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acHeaderHorzBottomColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acHeaderHorzBottomColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHeaderHorzBottomColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acHeaderHorzBottomColor);

		}
	}


	[NVP_Manifest(
		Id = "69C878EC-FF7A-4DE3-A5C5-E12CBCBF1C8D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acHeaderVertLeftColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acHeaderVertLeftColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHeaderVertLeftColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acHeaderVertLeftColor);

		}
	}


	[NVP_Manifest(
		Id = "02692D71-BDD9-46DE-ADD5-BE5FCF3A1451", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acHeaderVertInsideColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acHeaderVertInsideColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHeaderVertInsideColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acHeaderVertInsideColor);

		}
	}


	[NVP_Manifest(
		Id = "925EAB4E-B74C-4B6F-AA3B-CD8E2BF54BCF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acHeaderVertRightColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acHeaderVertRightColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHeaderVertRightColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acHeaderVertRightColor);

		}
	}


	[NVP_Manifest(
		Id = "CB09C5A1-FB5B-48C4-B2B1-ECBFA9ED10F8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acDataHorzTopColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acDataHorzTopColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDataHorzTopColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acDataHorzTopColor);

		}
	}


	[NVP_Manifest(
		Id = "793608EC-39DB-4FC9-8F6E-C4712055BA41", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acDataHorzInsideColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acDataHorzInsideColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDataHorzInsideColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acDataHorzInsideColor);

		}
	}


	[NVP_Manifest(
		Id = "47386166-9012-454F-9041-C73CE43E7568", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acDataHorzBottomColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acDataHorzBottomColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDataHorzBottomColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acDataHorzBottomColor);

		}
	}


	[NVP_Manifest(
		Id = "C4A541DD-376D-4E49-846F-FC7805A4A4D5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acDataVertLeftColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acDataVertLeftColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDataVertLeftColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acDataVertLeftColor);

		}
	}


	[NVP_Manifest(
		Id = "C2B5E34E-7957-49CF-99FC-3FF8697672BE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acDataVertInsideColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acDataVertInsideColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDataVertInsideColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acDataVertInsideColor);

		}
	}


	[NVP_Manifest(
		Id = "AF9B44A2-FE81-4376-82FA-F8E1B9B2C00C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acDataVertRightColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acDataVertRightColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDataVertRightColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acDataVertRightColor);

		}
	}


	[NVP_Manifest(
		Id = "F7046F8F-B7B9-4508-9343-F65739350039", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acTitleHorzTopLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acTitleHorzTopLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTitleHorzTopLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acTitleHorzTopLineWeight);

		}
	}


	[NVP_Manifest(
		Id = "5AA75702-26EF-45C5-A054-4AA128234BF1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acTitleHorzInsideLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acTitleHorzInsideLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTitleHorzInsideLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acTitleHorzInsideLineWeight);

		}
	}


	[NVP_Manifest(
		Id = "E79B2E10-8489-4C24-AE9C-72B8C49F8B51", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acTitleHorzBottomLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acTitleHorzBottomLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTitleHorzBottomLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acTitleHorzBottomLineWeight);

		}
	}


	[NVP_Manifest(
		Id = "7FB3EACF-472D-424D-A980-16B2B76F4016", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acTitleVertLeftLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acTitleVertLeftLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTitleVertLeftLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acTitleVertLeftLineWeight);

		}
	}


	[NVP_Manifest(
		Id = "EFFF207E-361D-4AF1-A952-B460EF3637F2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acTitleVertInsideLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acTitleVertInsideLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTitleVertInsideLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acTitleVertInsideLineWeight);

		}
	}


	[NVP_Manifest(
		Id = "AFA4EFCF-63AE-4EFD-A243-147C2DB317C6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acTitleVertRightLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acTitleVertRightLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTitleVertRightLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acTitleVertRightLineWeight);

		}
	}


	[NVP_Manifest(
		Id = "0B8541D4-D720-47AE-93DE-485A2972DF24", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acHeaderHorzTopLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acHeaderHorzTopLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHeaderHorzTopLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acHeaderHorzTopLineWeight);

		}
	}


	[NVP_Manifest(
		Id = "1372F885-444B-4AA2-B657-711C051CFFEC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acHeaderHorzInsideLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acHeaderHorzInsideLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHeaderHorzInsideLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acHeaderHorzInsideLineWeight);

		}
	}


	[NVP_Manifest(
		Id = "B28FF876-F452-4771-940A-84E6C2859901", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acHeaderHorzBottomLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acHeaderHorzBottomLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHeaderHorzBottomLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acHeaderHorzBottomLineWeight);

		}
	}


	[NVP_Manifest(
		Id = "84055501-8408-442D-9A20-9EB049D3869F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acHeaderVertLeftLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acHeaderVertLeftLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHeaderVertLeftLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acHeaderVertLeftLineWeight);

		}
	}


	[NVP_Manifest(
		Id = "0AFA5C3D-4EF6-4F41-A1AF-62755AA7D567", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acHeaderVertInsideLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acHeaderVertInsideLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHeaderVertInsideLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acHeaderVertInsideLineWeight);

		}
	}


	[NVP_Manifest(
		Id = "E7CF1DA9-5F3D-4108-A0AB-0F943F4E43F9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acHeaderVertRightLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acHeaderVertRightLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHeaderVertRightLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acHeaderVertRightLineWeight);

		}
	}


	[NVP_Manifest(
		Id = "777CA7ED-8E84-4E57-8B44-260D99C4F25B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acDataHorzTopLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acDataHorzTopLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDataHorzTopLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acDataHorzTopLineWeight);

		}
	}


	[NVP_Manifest(
		Id = "B08CB2FB-156D-46B9-91FB-A7E7A818E826", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acDataHorzInsideLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acDataHorzInsideLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDataHorzInsideLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acDataHorzInsideLineWeight);

		}
	}


	[NVP_Manifest(
		Id = "4A3EF922-9832-472A-951A-6E327C9C1191", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acDataHorzBottomLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acDataHorzBottomLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDataHorzBottomLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acDataHorzBottomLineWeight);

		}
	}


	[NVP_Manifest(
		Id = "F1FF25C1-B62E-452F-A016-564321833FEA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acDataVertLeftLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acDataVertLeftLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDataVertLeftLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acDataVertLeftLineWeight);

		}
	}


	[NVP_Manifest(
		Id = "A59AB541-1CEE-4FE8-AFD4-595BDFDB70FB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acDataVertInsideLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acDataVertInsideLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDataVertInsideLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acDataVertInsideLineWeight);

		}
	}


	[NVP_Manifest(
		Id = "83180155-D9B0-4590-8032-CBD8E9DF3F2D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acDataVertRightLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acDataVertRightLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDataVertRightLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acDataVertRightLineWeight);

		}
	}


	[NVP_Manifest(
		Id = "97AC0E6D-2C59-49D4-966F-393E8885D257", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acTitleHorzTopVisibility", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acTitleHorzTopVisibility", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTitleHorzTopVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acTitleHorzTopVisibility);

		}
	}


	[NVP_Manifest(
		Id = "7C18ADFE-D4DB-489B-912F-52FB1E89A6D3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acTitleHorzInsideVisibility", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acTitleHorzInsideVisibility", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTitleHorzInsideVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acTitleHorzInsideVisibility);

		}
	}


	[NVP_Manifest(
		Id = "B4CB1E43-D43D-4697-B0AD-8DDEC1890823", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acTitleHorzBottomVisibility", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acTitleHorzBottomVisibility", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTitleHorzBottomVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acTitleHorzBottomVisibility);

		}
	}


	[NVP_Manifest(
		Id = "DAB4F92C-3A09-4915-9637-EAC997D62F0D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acTitleVertLeftVisibility", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acTitleVertLeftVisibility", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTitleVertLeftVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acTitleVertLeftVisibility);

		}
	}


	[NVP_Manifest(
		Id = "C77B4CA0-F3F7-474C-9E89-CBFA9A797D8A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acTitleVertInsideVisibility", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acTitleVertInsideVisibility", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTitleVertInsideVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acTitleVertInsideVisibility);

		}
	}


	[NVP_Manifest(
		Id = "E13D0DAA-01A1-48BE-9089-7FA7D47769A6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acTitleVertRightVisibility", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acTitleVertRightVisibility", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acTitleVertRightVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acTitleVertRightVisibility);

		}
	}


	[NVP_Manifest(
		Id = "421575F0-BFBA-4E08-908A-0FD919AB5212", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acHeaderHorzTopVisibility", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acHeaderHorzTopVisibility", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHeaderHorzTopVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acHeaderHorzTopVisibility);

		}
	}


	[NVP_Manifest(
		Id = "0E9D5406-6D7F-4BFF-BD29-588386CE89DD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acHeaderHorzInsideVisibility", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acHeaderHorzInsideVisibility", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHeaderHorzInsideVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acHeaderHorzInsideVisibility);

		}
	}


	[NVP_Manifest(
		Id = "9973677A-D09F-468B-BDFF-8C2EFE3163E9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acHeaderHorzBottomVisibility", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acHeaderHorzBottomVisibility", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHeaderHorzBottomVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acHeaderHorzBottomVisibility);

		}
	}


	[NVP_Manifest(
		Id = "C09689FA-1E0E-4064-ADA9-1F61663DE2AF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acHeaderVertLeftVisibility", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acHeaderVertLeftVisibility", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHeaderVertLeftVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acHeaderVertLeftVisibility);

		}
	}


	[NVP_Manifest(
		Id = "0A607582-BB21-4C73-AB5A-CE5C7C8A5577", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acHeaderVertInsideVisibility", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acHeaderVertInsideVisibility", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHeaderVertInsideVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acHeaderVertInsideVisibility);

		}
	}


	[NVP_Manifest(
		Id = "863BFFEB-AA0B-432A-B448-1106D86FC395", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acHeaderVertRightVisibility", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acHeaderVertRightVisibility", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acHeaderVertRightVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acHeaderVertRightVisibility);

		}
	}


	[NVP_Manifest(
		Id = "DC00159E-3A97-4088-91B4-10940CC15291", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acDataHorzTopVisibility", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acDataHorzTopVisibility", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDataHorzTopVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acDataHorzTopVisibility);

		}
	}


	[NVP_Manifest(
		Id = "CC09F1BE-B6A4-4B80-A336-3BD933900AA8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acDataHorzInsideVisibility", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acDataHorzInsideVisibility", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDataHorzInsideVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acDataHorzInsideVisibility);

		}
	}


	[NVP_Manifest(
		Id = "E00A84E5-1068-428B-B693-10670C5FF25B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acDataHorzBottomVisibility", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acDataHorzBottomVisibility", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDataHorzBottomVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acDataHorzBottomVisibility);

		}
	}


	[NVP_Manifest(
		Id = "CD0D8761-52C4-4545-80D4-55A6996E2D65", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acDataVertLeftVisibility", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acDataVertLeftVisibility", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDataVertLeftVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acDataVertLeftVisibility);

		}
	}


	[NVP_Manifest(
		Id = "2E988B30-D78C-49AC-9A5C-3209A9582839", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acDataVertInsideVisibility", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acDataVertInsideVisibility", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDataVertInsideVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acDataVertInsideVisibility);

		}
	}


	[NVP_Manifest(
		Id = "6322F128-005E-4819-8470-6087AC135480", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acDataVertRightVisibility", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acDataVertRightVisibility", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acDataVertRightVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acDataVertRightVisibility);

		}
	}


	[NVP_Manifest(
		Id = "B02158AE-7950-4B53-BB3C-278E204032F2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acCellAlign", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acCellAlign", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acCellAlign : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acCellAlign);

		}
	}


	[NVP_Manifest(
		Id = "BCAC0C86-8132-4157-AE5A-46C1F82CBE6A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acCellBackgroundFillNone", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acCellBackgroundFillNone", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acCellBackgroundFillNone : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acCellBackgroundFillNone);

		}
	}


	[NVP_Manifest(
		Id = "BFDC7D89-EE5A-44B8-A333-1AD62FA12A07", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acCellBackgroundColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acCellBackgroundColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acCellBackgroundColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acCellBackgroundColor);

		}
	}


	[NVP_Manifest(
		Id = "1ED4246D-7AD3-4E4E-9448-B2E6AC1BDC0D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acCellContentColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acCellContentColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acCellContentColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acCellContentColor);

		}
	}


	[NVP_Manifest(
		Id = "02A6765A-70A0-478D-87D2-5D49F5DAD28E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acCellTextStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acCellTextStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acCellTextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acCellTextStyle);

		}
	}


	[NVP_Manifest(
		Id = "876ADEEA-4467-42C8-BBB1-4B7A8D8FC581", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acCellTextHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acCellTextHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acCellTextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acCellTextHeight);

		}
	}


	[NVP_Manifest(
		Id = "EEAA5BFB-4C38-49F0-9D15-4BF6D5C4B91A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acCellTopGridColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acCellTopGridColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acCellTopGridColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acCellTopGridColor);

		}
	}


	[NVP_Manifest(
		Id = "E401223F-73D1-47FD-B61B-B7302C76FABE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acCellRightGridColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acCellRightGridColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acCellRightGridColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acCellRightGridColor);

		}
	}


	[NVP_Manifest(
		Id = "2946EE88-49E8-4080-BBD4-C868EEAC2ED8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acCellBottomGridColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acCellBottomGridColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acCellBottomGridColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acCellBottomGridColor);

		}
	}


	[NVP_Manifest(
		Id = "B127EA23-A067-4A2E-BAE5-9FA1E8E7884C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acCellLeftGridColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acCellLeftGridColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acCellLeftGridColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acCellLeftGridColor);

		}
	}


	[NVP_Manifest(
		Id = "57A4A366-031E-4BDB-8C91-88722F575286", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acCellTopGridLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acCellTopGridLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acCellTopGridLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acCellTopGridLineWeight);

		}
	}


	[NVP_Manifest(
		Id = "A4177C29-9A0F-4D44-AABD-69E6E332FD34", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acCellRightGridLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acCellRightGridLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acCellRightGridLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acCellRightGridLineWeight);

		}
	}


	[NVP_Manifest(
		Id = "CF54E4CE-F1C2-4A9C-A860-39AE5B45A8D6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acCellBottomGridLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acCellBottomGridLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acCellBottomGridLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acCellBottomGridLineWeight);

		}
	}


	[NVP_Manifest(
		Id = "AC05A603-AD4C-42F1-BBD8-274E7F25BFFC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acCellLeftGridLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acCellLeftGridLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acCellLeftGridLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acCellLeftGridLineWeight);

		}
	}


	[NVP_Manifest(
		Id = "D60A7C71-3B77-4CE6-9B21-956145483A2D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acCellTopVisibility", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acCellTopVisibility", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acCellTopVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acCellTopVisibility);

		}
	}


	[NVP_Manifest(
		Id = "764683A2-8E39-474D-85BD-BECB9D7B28E0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acCellRightVisibility", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acCellRightVisibility", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acCellRightVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acCellRightVisibility);

		}
	}


	[NVP_Manifest(
		Id = "ABA444F5-73B3-46EB-90C0-4A10018B77AA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acCellBottomVisibility", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acCellBottomVisibility", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acCellBottomVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acCellBottomVisibility);

		}
	}


	[NVP_Manifest(
		Id = "E93D14F6-9B2D-497C-9E83-B4D9CAC60CDD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acCellLeftVisibility", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acCellLeftVisibility", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acCellLeftVisibility : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acCellLeftVisibility);

		}
	}


	[NVP_Manifest(
		Id = "07B3097B-08BA-447C-A9DE-5A0416FD3261", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.enum_AcTableStyleOverrides.enum_acCellDataType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.enum_AcTableStyleOverrides", 
		NodeName = "enum_acCellDataType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Default")]

	///<summary>
	///
	///</summary>
	public class enum_acCellDataType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			return new NodeResult(OdaX.AcTableStyleOverrides.acCellDataType);

		}
	}
}
