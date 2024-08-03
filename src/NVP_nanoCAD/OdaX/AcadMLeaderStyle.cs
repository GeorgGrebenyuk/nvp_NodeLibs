using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///MLeaderStyle Interface
///</summary>
namespace OdaX.AcadMLeaderStyle 
{

	[NVP_Manifest(
		Id = "5B377617-9E90-4AC4-AA24-AF854940B356", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.AcadMLeaderStyle_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "_AcadMLeaderStyle_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadMLeaderStyle_Constructor : INode 
	{
		public OdaX.IAcadMLeaderStyle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadMLeaderStyle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "2121E5FE-EECE-4DEA-ABBA-418C67C99CBE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.AcadMLeaderStyle_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "_AcadMLeaderStyle_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadMLeaderStyle_ConstructorCast : INode 
	{
		public OdaX.IAcadMLeaderStyle _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadMLeaderStyle;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "4AFE706A-5A68-45D2-BAA4-093B9D197C34", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the name of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the name of a multileader style.
	///</summary>
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	[NVP_Manifest(
		Id = "92BED5E3-32FE-443A-9DA0-9A645F86DA8F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Set_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Set_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the name of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Specifies or returns the name of a multileader style.
	///</summary>
	public class Set_Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Name = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C4E94C8B-C7FF-49F3-B5B4-15E03D6FDE5D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Description", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Description", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the description of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the description of a multileader style.
	///</summary>
	public class Description : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Description);

		}
	}


	[NVP_Manifest(
		Id = "486E88C3-031A-4975-9C14-7EB891572B7B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Set_Description", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Set_Description", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the description of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("Description", typeof(System.String))]

	///<summary>
	///Specifies or returns the description of a multileader style.
	///</summary>
	public class Set_Description : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Description = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "364240A6-A598-48DF-8333-5088F317AAA6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.BitFlags", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "BitFlags", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the operation bit set of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the operation bit set of a multileader style.
	///</summary>
	public class BitFlags : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BitFlags);

		}
	}


	[NVP_Manifest(
		Id = "9403B1D2-A6D6-449A-9DE3-71FAE26E1FA7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Set_BitFlags", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Set_BitFlags", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the operation bit set of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("bitFlag", typeof(System.Object))]

	///<summary>
	///Specifies or returns the operation bit set of a multileader style.
	///</summary>
	public class Set_BitFlags : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BitFlags = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "30328F3E-C4F9-42BF-8F90-7340843D4FA3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.ContentType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "ContentType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the content type of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the content type of a multileader style.
	///</summary>
	public class ContentType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ContentType);

		}
	}


	[NVP_Manifest(
		Id = "E5BB5CFA-AD8F-48B4-AF92-AE44B7A3E3BA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Set_ContentType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Set_ContentType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the content type of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("OdaX.AcMLeaderContentType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the content type of a multileader style.
	///</summary>
	public class Set_ContentType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ContentType = ((OdaX.AcMLeaderContentType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "CB862CB0-75A3-453E-B479-954EDFB6FB1A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.DrawMLeaderOrderType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "DrawMLeaderOrderType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the order of multileader creation for a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the order of multileader creation for a multileader style.
	///</summary>
	public class DrawMLeaderOrderType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DrawMLeaderOrderType);

		}
	}


	[NVP_Manifest(
		Id = "34C821D2-51B1-43CE-A42A-4CD52319CC5C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Set_DrawMLeaderOrderType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Set_DrawMLeaderOrderType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the order of multileader creation for a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("OdaX.AcDrawMLeaderOrderType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the order of multileader creation for a multileader style.
	///</summary>
	public class Set_DrawMLeaderOrderType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DrawMLeaderOrderType = ((OdaX.AcDrawMLeaderOrderType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3C9A5353-559E-4FEF-A919-8F1023C28874", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.DrawLeaderOrderType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "DrawLeaderOrderType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the order of leader creation for a multileader of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the order of leader creation for a multileader of a multileader style.
	///</summary>
	public class DrawLeaderOrderType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DrawLeaderOrderType);

		}
	}


	[NVP_Manifest(
		Id = "BB3CE261-61BE-4386-AEE8-6E12DBA7FEE4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Set_DrawLeaderOrderType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Set_DrawLeaderOrderType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the order of leader creation for a multileader of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("OdaX.AcDrawLeaderOrderType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the order of leader creation for a multileader of a multileader style.
	///</summary>
	public class Set_DrawLeaderOrderType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DrawLeaderOrderType = ((OdaX.AcDrawLeaderOrderType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A386101D-56B8-4D7B-82A3-8B2B615FD862", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.MaxLeaderSegmentsPoints", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "MaxLeaderSegmentsPoints", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the maximum number of segment points in multileader lines of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the maximum number of segment points in multileader lines of a multileader style.
	///</summary>
	public class MaxLeaderSegmentsPoints : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.MaxLeaderSegmentsPoints);

		}
	}


	[NVP_Manifest(
		Id = "14857F8F-DC2C-4350-9E72-C4338027697D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Set_MaxLeaderSegmentsPoints", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Set_MaxLeaderSegmentsPoints", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the maximum number of segment points in multileader lines of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("number", typeof(System.Int32))]

	///<summary>
	///Specifies or returns the maximum number of segment points in multileader lines of a multileader style.
	///</summary>
	public class Set_MaxLeaderSegmentsPoints : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.MaxLeaderSegmentsPoints = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "EFCFDBD0-06DC-432F-AA4D-280DD326B349", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.FirstSegmentAngleConstraint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "FirstSegmentAngleConstraint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the first segment angle constraint for a multileader of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the first segment angle constraint for a multileader of a multileader style.
	///</summary>
	public class FirstSegmentAngleConstraint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FirstSegmentAngleConstraint);

		}
	}


	[NVP_Manifest(
		Id = "8565B843-D90C-45D1-9F67-17332772CF18", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Set_FirstSegmentAngleConstraint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Set_FirstSegmentAngleConstraint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the first segment angle constraint for a multileader of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("OdaX.AcSegmentAngleType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the first segment angle constraint for a multileader of a multileader style.
	///</summary>
	public class Set_FirstSegmentAngleConstraint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FirstSegmentAngleConstraint = ((OdaX.AcSegmentAngleType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "20D26606-F447-4B57-B9A2-12835AC11759", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.SecondSegmentAngleConstraint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "SecondSegmentAngleConstraint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the second segment angle constraint for a multileader of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the second segment angle constraint for a multileader of a multileader style.
	///</summary>
	public class SecondSegmentAngleConstraint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SecondSegmentAngleConstraint);

		}
	}


	[NVP_Manifest(
		Id = "E21845D5-F374-4087-ADFE-3952DB734F82", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Set_SecondSegmentAngleConstraint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Set_SecondSegmentAngleConstraint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the second segment angle constraint for a multileader of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("OdaX.AcSegmentAngleType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the second segment angle constraint for a multileader of a multileader style.
	///</summary>
	public class Set_SecondSegmentAngleConstraint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SecondSegmentAngleConstraint = ((OdaX.AcSegmentAngleType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5E6287AB-4921-42E3-9AFC-AE3FA5A5234B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.LeaderLineType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "LeaderLineType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the leader line type of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the leader line type of a multileader style.
	///</summary>
	public class LeaderLineType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LeaderLineType);

		}
	}


	[NVP_Manifest(
		Id = "6B239099-1E1E-412E-ABA1-5EAE6B9E4C95", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Set_LeaderLineType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Set_LeaderLineType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the leader line type of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("OdaX.AcMLeaderType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the leader line type of a multileader style.
	///</summary>
	public class Set_LeaderLineType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LeaderLineType = ((OdaX.AcMLeaderType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9E9C1DA7-B5E3-4E90-AF9C-C712C8541F40", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.LeaderLineColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "LeaderLineColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the color of leader lines for a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the color of leader lines for a multileader style.
	///</summary>
	public class LeaderLineColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LeaderLineColor);

		}
	}


	[NVP_Manifest(
		Id = "7E8CF55D-3F7E-41DE-95C9-C4FDEC4EC925", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Set_LeaderLineColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Set_LeaderLineColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the color of leader lines for a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("color", typeof(System.Object))]

	///<summary>
	///Specifies or returns the color of leader lines for a multileader style.
	///</summary>
	public class Set_LeaderLineColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LeaderLineColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "AF68CEA5-6434-43ED-82C2-C12E3B954EFD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.LeaderLineTypeId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "LeaderLineTypeId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the linetype of leader lines for a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the linetype of leader lines for a multileader style.
	///</summary>
	public class LeaderLineTypeId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LeaderLineTypeId);

		}
	}


	[NVP_Manifest(
		Id = "3F00074B-3603-44A7-ADC6-44239BBB5D33", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Set_LeaderLineTypeId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Set_LeaderLineTypeId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the linetype of leader lines for a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("Type", typeof(System.Object))]

	///<summary>
	///Specifies or returns the linetype of leader lines for a multileader style.
	///</summary>
	public class Set_LeaderLineTypeId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LeaderLineTypeId = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5924D926-F8A7-4AA0-A5C0-47953291F180", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.LeaderLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "LeaderLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the lineweight of leader lines for a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the lineweight of leader lines for a multileader style.
	///</summary>
	public class LeaderLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LeaderLineWeight);

		}
	}


	[NVP_Manifest(
		Id = "1F9156A7-0B73-496D-BE18-AED8784C224F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Set_LeaderLineWeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Set_LeaderLineWeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the lineweight of leader lines for a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("OdaX.AcLineWeight", typeof(System.Object))]

	///<summary>
	///Specifies or returns the lineweight of leader lines for a multileader style.
	///</summary>
	public class Set_LeaderLineWeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LeaderLineWeight = ((OdaX.AcLineWeight)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "FBD5BDF0-15C6-462C-9935-751B2C640DA6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.EnableLanding", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "EnableLanding", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the landing of leader lines is enabled for a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns whether the landing of leader lines is enabled for a multileader style.
	///</summary>
	public class EnableLanding : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EnableLanding);

		}
	}


	[NVP_Manifest(
		Id = "AF6C0BEC-5CD9-4BBC-B36E-07A6250BACA6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Set_EnableLanding", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Set_EnableLanding", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the landing of leader lines is enabled for a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("enabled", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the landing of leader lines is enabled for a multileader style.
	///</summary>
	public class Set_EnableLanding : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EnableLanding = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "966D20BB-CBA3-4901-BC23-35E22FCF066A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.LandingGap", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "LandingGap", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the gap between multiline text and the tail of leader lines for a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the gap between multiline text and the tail of leader lines for a multileader style.
	///</summary>
	public class LandingGap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LandingGap);

		}
	}


	[NVP_Manifest(
		Id = "DBAB9AED-AC99-4CDF-B94E-7E1B3B972E06", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Set_LandingGap", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Set_LandingGap", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the gap between multiline text and the tail of leader lines for a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("LandingGap", typeof(System.Double))]

	///<summary>
	///Specifies or returns the gap between multiline text and the tail of leader lines for a multileader style.
	///</summary>
	public class Set_LandingGap : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LandingGap = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "61E6CDAB-6FF5-495F-9982-0E3F79D0AD6E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.EnableDogleg", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "EnableDogleg", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether dog legs are enabled for leader lines of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns whether dog legs are enabled for leader lines of a multileader style.
	///</summary>
	public class EnableDogleg : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EnableDogleg);

		}
	}


	[NVP_Manifest(
		Id = "558CCB85-BFC9-484D-96FC-3413CD686BFE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Set_EnableDogleg", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Set_EnableDogleg", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether dog legs are enabled for leader lines of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("enabled", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether dog legs are enabled for leader lines of a multileader style.
	///</summary>
	public class Set_EnableDogleg : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EnableDogleg = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5EBF4863-B8DB-448B-9DE6-070DE7434243", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.DoglegLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "DoglegLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the dog leg length for leader lines of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the dog leg length for leader lines of a multileader style.
	///</summary>
	public class DoglegLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.DoglegLength);

		}
	}


	[NVP_Manifest(
		Id = "B79E7C6B-754C-49BD-8CA2-3D2800F58FF2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Set_DoglegLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Set_DoglegLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the dog leg length for leader lines of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("DoglegLength", typeof(System.Double))]

	///<summary>
	///Specifies or returns the dog leg length for leader lines of a multileader style.
	///</summary>
	public class Set_DoglegLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.DoglegLength = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "ADE5AEAD-3C2E-4D41-A512-6836B69A9643", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.ArrowSymbol", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "ArrowSymbol", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the arrow symbol of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the arrow symbol of a multileader style.
	///</summary>
	public class ArrowSymbol : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrowSymbol);

		}
	}


	[NVP_Manifest(
		Id = "1136A6C7-C8E2-4F7D-99C5-48D0513C705B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Set_ArrowSymbol", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Set_ArrowSymbol", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the arrow symbol of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Specifies or returns the arrow symbol of a multileader style.
	///</summary>
	public class Set_ArrowSymbol : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrowSymbol = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "809E3BC5-8FBE-4B04-B1C7-8D5767CBA73B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.ArrowSize", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "ArrowSize", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the arrow size of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the arrow size of a multileader style.
	///</summary>
	public class ArrowSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArrowSize);

		}
	}


	[NVP_Manifest(
		Id = "113F47EE-A4A8-43A2-9EAC-55FB0DA88E73", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Set_ArrowSize", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Set_ArrowSize", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the arrow size of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("size", typeof(System.Double))]

	///<summary>
	///Specifies or returns the arrow size of a multileader style.
	///</summary>
	public class Set_ArrowSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArrowSize = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "BFE1270B-0A6C-4D58-AE3B-68CA61ACB56C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.TextStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "TextStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the text style of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the text style of a multileader style.
	///</summary>
	public class TextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextStyle);

		}
	}


	[NVP_Manifest(
		Id = "EF5A5800-7EE6-4A1F-914C-5993149DB913", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Set_TextStyle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Set_TextStyle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the text style of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Specifies or returns the text style of a multileader style.
	///</summary>
	public class Set_TextStyle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextStyle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E319812A-7D17-45F9-964C-8F799E6D6C69", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.TextLeftAttachmentType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "TextLeftAttachmentType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how left-aligned text is positioned for a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns how left-aligned text is positioned for a multileader style.
	///</summary>
	public class TextLeftAttachmentType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextLeftAttachmentType);

		}
	}


	[NVP_Manifest(
		Id = "EFBEA38C-5F71-452E-90E7-44B417853BED", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Set_TextLeftAttachmentType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Set_TextLeftAttachmentType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how left-aligned text is positioned for a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("OdaX.AcTextAttachmentType", typeof(System.Object))]

	///<summary>
	///Specifies or returns how left-aligned text is positioned for a multileader style.
	///</summary>
	public class Set_TextLeftAttachmentType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextLeftAttachmentType = ((OdaX.AcTextAttachmentType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "74175897-B9C2-4897-BF7F-B8633CF4DB04", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.TextRightAttachmentType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "TextRightAttachmentType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how right-aligned text is positioned for a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns how right-aligned text is positioned for a multileader style.
	///</summary>
	public class TextRightAttachmentType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextRightAttachmentType);

		}
	}


	[NVP_Manifest(
		Id = "D2551971-2B23-49DC-ADF0-9128FF9ED9E8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Set_TextRightAttachmentType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Set_TextRightAttachmentType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns how right-aligned text is positioned for a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("OdaX.AcTextAttachmentType", typeof(System.Object))]

	///<summary>
	///Specifies or returns how right-aligned text is positioned for a multileader style.
	///</summary>
	public class Set_TextRightAttachmentType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextRightAttachmentType = ((OdaX.AcTextAttachmentType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0D39E715-70D9-4ED7-9437-400E2B155267", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.TextColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "TextColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the multline text color of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the multline text color of a multileader style.
	///</summary>
	public class TextColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextColor);

		}
	}


	[NVP_Manifest(
		Id = "449B20A5-BF00-437B-B8D1-853A52077D11", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Set_TextColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Set_TextColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the multline text color of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("color", typeof(System.Object))]

	///<summary>
	///Specifies or returns the multline text color of a multileader style.
	///</summary>
	public class Set_TextColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "ECE46B17-CA58-49FC-842B-5F200020BB76", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.TextHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "TextHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the multline text height of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the multline text height of a multileader style.
	///</summary>
	public class TextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextHeight);

		}
	}


	[NVP_Manifest(
		Id = "D8E079E4-B98B-4337-AC42-D1C3BD4C0104", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Set_TextHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Set_TextHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the multline text height of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Specifies or returns the multline text height of a multileader style.
	///</summary>
	public class Set_TextHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextHeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B56C8B15-9D43-44C5-8F7A-7DEC3BE9C04D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.EnableFrameText", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "EnableFrameText", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a frame displays around multline text of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns whether a frame displays around multline text of a multileader style.
	///</summary>
	public class EnableFrameText : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EnableFrameText);

		}
	}


	[NVP_Manifest(
		Id = "69764D36-AD51-4249-830B-FBE65C573E41", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Set_EnableFrameText", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Set_EnableFrameText", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether a frame displays around multline text of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("enabled", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether a frame displays around multline text of a multileader style.
	///</summary>
	public class Set_EnableFrameText : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EnableFrameText = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "CBC85613-67E6-4D1C-8FE0-FA061235CC02", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.AlignSpace", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "AlignSpace", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the alignment space value of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the alignment space value of a multileader style.
	///</summary>
	public class AlignSpace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.AlignSpace);

		}
	}


	[NVP_Manifest(
		Id = "EAD3C447-8650-4EF4-9061-F91DDE37926F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Set_AlignSpace", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Set_AlignSpace", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the alignment space value of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("AlignSpace", typeof(System.Double))]

	///<summary>
	///Specifies or returns the alignment space value of a multileader style.
	///</summary>
	public class Set_AlignSpace : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AlignSpace = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D6FBC0DC-A13F-4FD6-8427-B988197E172C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Block", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Block", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the block content of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the block content of a multileader style.
	///</summary>
	public class Block : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Block);

		}
	}


	[NVP_Manifest(
		Id = "665BDF37-CFAF-4083-BB5E-0A7614628150", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Set_Block", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Set_Block", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the block content of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("Name", typeof(System.String))]

	///<summary>
	///Specifies or returns the block content of a multileader style.
	///</summary>
	public class Set_Block : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Block = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "93EE63FA-269C-4276-82FA-09805F280704", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.BlockColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "BlockColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the color of block content for a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the color of block content for a multileader style.
	///</summary>
	public class BlockColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BlockColor);

		}
	}


	[NVP_Manifest(
		Id = "772DFDC5-558C-45CB-BCED-9539FBBC4A16", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Set_BlockColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Set_BlockColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the color of block content for a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("color", typeof(System.Object))]

	///<summary>
	///Specifies or returns the color of block content for a multileader style.
	///</summary>
	public class Set_BlockColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BlockColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A588DD85-E1A8-44F5-A7DE-55F16C1B6163", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.EnableBlockScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "EnableBlockScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the blocks are scaled for a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns whether the blocks are scaled for a multileader style.
	///</summary>
	public class EnableBlockScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EnableBlockScale);

		}
	}


	[NVP_Manifest(
		Id = "C5DAD265-A576-4D16-952C-B0808266AD50", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Set_EnableBlockScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Set_EnableBlockScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether the blocks are scaled for a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("enabled", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether the blocks are scaled for a multileader style.
	///</summary>
	public class Set_EnableBlockScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EnableBlockScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "72550DA9-4EC2-4800-A944-34674F4317D7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.BlockScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "BlockScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the block scale value for a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the block scale value for a multileader style.
	///</summary>
	public class BlockScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BlockScale);

		}
	}


	[NVP_Manifest(
		Id = "8C1C7C62-4812-44B3-844D-A8AA1D5009A6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Set_BlockScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Set_BlockScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the block scale value for a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("ScaleFactor", typeof(System.Double))]

	///<summary>
	///Specifies or returns the block scale value for a multileader style.
	///</summary>
	public class Set_BlockScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BlockScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "6BAA7A2E-8225-4A5C-98E7-37C69026E626", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.EnableBlockRotation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "EnableBlockRotation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether blocks are rotated for a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns whether blocks are rotated for a multileader style.
	///</summary>
	public class EnableBlockRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.EnableBlockRotation);

		}
	}


	[NVP_Manifest(
		Id = "42FE4101-8BF8-41DE-B328-A77CE1239B96", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Set_EnableBlockRotation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Set_EnableBlockRotation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns whether blocks are rotated for a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("enabled", typeof(System.Object))]

	///<summary>
	///Specifies or returns whether blocks are rotated for a multileader style.
	///</summary>
	public class Set_EnableBlockRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.EnableBlockRotation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "9E3C565C-07E6-4999-BB14-2A466656CA6D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.BlockRotation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "BlockRotation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the rotation value for a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the rotation value for a multileader style.
	///</summary>
	public class BlockRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BlockRotation);

		}
	}


	[NVP_Manifest(
		Id = "2D1C4419-60A6-43C8-93E1-57331F2CA91D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Set_BlockRotation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Set_BlockRotation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the rotation value for a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("Rotation", typeof(System.Double))]

	///<summary>
	///Specifies or returns the rotation value for a multileader style.
	///</summary>
	public class Set_BlockRotation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BlockRotation = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7BF7AFAE-970C-4B05-91BB-B1895A813CFE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.BlockConnectionType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "BlockConnectionType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the block connection type of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the block connection type of a multileader style.
	///</summary>
	public class BlockConnectionType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BlockConnectionType);

		}
	}


	[NVP_Manifest(
		Id = "F213F9CA-156E-40D9-99DF-2A7921EAED71", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Set_BlockConnectionType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Set_BlockConnectionType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the block connection type of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("OdaX.AcBlockConnectionType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the block connection type of a multileader style.
	///</summary>
	public class Set_BlockConnectionType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BlockConnectionType = ((OdaX.AcBlockConnectionType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "652FCDD0-3117-445D-8841-1A5F421F3755", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.ScaleFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "ScaleFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the multileader scale of a specified multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the multileader scale of a specified multileader style.
	///</summary>
	public class ScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ScaleFactor);

		}
	}


	[NVP_Manifest(
		Id = "F4E18FCD-AC83-4E8C-843F-A2831119E90B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Set_ScaleFactor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Set_ScaleFactor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the multileader scale of a specified multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("scale", typeof(System.Double))]

	///<summary>
	///Specifies or returns the multileader scale of a specified multileader style.
	///</summary>
	public class Set_ScaleFactor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ScaleFactor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1A55FF7E-C805-40DD-87A1-9E7BD13BFA6F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.OverwritePropChanged", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "OverwritePropChanged", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns whether properties were changed for a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Returns whether properties were changed for a multileader style.
	///</summary>
	public class OverwritePropChanged : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OverwritePropChanged);

		}
	}


	[NVP_Manifest(
		Id = "033F434A-F639-4008-A6E8-D38D8DD84CE3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Annotative", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Annotative", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the annotative status of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the annotative status of a multileader style.
	///</summary>
	public class Annotative : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Annotative);

		}
	}


	[NVP_Manifest(
		Id = "3712F399-2EA6-41C1-B67F-FDFA21E26C1F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Set_Annotative", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Set_Annotative", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the annotative status of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("Annotative", typeof(System.Object))]

	///<summary>
	///Specifies or returns the annotative status of a multileader style.
	///</summary>
	public class Set_Annotative : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Annotative = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E32635FD-D52E-42DB-94C2-8BB5939B1882", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.BreakSize", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "BreakSize", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the gap size used for breaking leader lines of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the gap size used for breaking leader lines of a multileader style.
	///</summary>
	public class BreakSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BreakSize);

		}
	}


	[NVP_Manifest(
		Id = "98709743-2FDA-4AB5-9203-F5DFFABB5B66", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Set_BreakSize", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Set_BreakSize", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the gap size used for breaking leader lines of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("size", typeof(System.Double))]

	///<summary>
	///Specifies or returns the gap size used for breaking leader lines of a multileader style.
	///</summary>
	public class Set_BreakSize : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BreakSize = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E1BE6666-73A7-4807-9554-8788D86512B4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.TextString", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "TextString", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the multiline text text string of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the multiline text text string of a multileader style.
	///</summary>
	public class TextString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextString);

		}
	}


	[NVP_Manifest(
		Id = "06A9E4A5-936F-49B3-8188-3B1D09E45DDB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Set_TextString", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Set_TextString", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the multiline text text string of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("Text", typeof(System.String))]

	///<summary>
	///Specifies or returns the multiline text text string of a multileader style.
	///</summary>
	public class Set_TextString : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextString = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "BDE0D719-566D-4EE2-8628-F7AA1A44244B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.TextAngleType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "TextAngleType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the text angle type of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the text angle type of a multileader style.
	///</summary>
	public class TextAngleType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextAngleType);

		}
	}


	[NVP_Manifest(
		Id = "9F1BFBE8-9F13-47E3-BEF7-A184A86FD3E2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Set_TextAngleType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Set_TextAngleType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the text angle type of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("OdaX.AcTextAngleType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the text angle type of a multileader style.
	///</summary>
	public class Set_TextAngleType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextAngleType = ((OdaX.AcTextAngleType)inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0DEA38CC-2590-41E3-946A-D7F1439ED49F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.TextAlignmentType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "TextAlignmentType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the text alignment type of a multileader style.", 
		ViewType = "Data")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]

	///<summary>
	///Specifies or returns the text alignment type of a multileader style.
	///</summary>
	public class TextAlignmentType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.TextAlignmentType);

		}
	}


	[NVP_Manifest(
		Id = "399E6F51-B1BA-4561-B708-3EBBD2D319A6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadMLeaderStyle.Set_TextAlignmentType", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadMLeaderStyle", 
		NodeName = "Set_TextAlignmentType", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the text alignment type of a multileader style.", 
		ViewType = "Modifier")]
	[NodeInput("AcadMLeaderStyle", typeof(object))]
	[NodeInput("OdaX.AcTextAlignmentType", typeof(System.Object))]

	///<summary>
	///Specifies or returns the text alignment type of a multileader style.
	///</summary>
	public class Set_TextAlignmentType : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TextAlignmentType = ((OdaX.AcTextAlignmentType)inputs[1].Value);
			return null;
		}
	}
}
