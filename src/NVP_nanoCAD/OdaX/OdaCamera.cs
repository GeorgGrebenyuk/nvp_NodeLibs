using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///Interface for a Camera entity
///</summary>
namespace OdaX.OdaCamera 
{

	[NVP_Manifest(
		Id = "4C51D213-32EF-492F-A0F4-D56DA92555C5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaCamera.OdaCamera_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaCamera", 
		NodeName = "_OdaCamera_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OdaCamera_Constructor : INode 
	{
		public OdaX.IOdaCamera _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IOdaCamera;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "54ADEFCC-6796-4187-B443-33F037D73A62", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaCamera.OdaCamera_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaCamera", 
		NodeName = "_OdaCamera_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class OdaCamera_ConstructorCast : INode 
	{
		public OdaX.IOdaCamera _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IOdaCamera;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "DA18B4D5-DA95-44A5-BA1C-AEF947E48F7D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaCamera.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaCamera", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaCamera", typeof(object))]

	///<summary>
	///
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
		Id = "59AEC6AA-E40C-43CC-BB18-3E792FA6EDEB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaCamera.Set_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaCamera", 
		NodeName = "Set_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaCamera", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///
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
		Id = "1B5690D7-AD6E-4F72-8EAC-432DCAF735BA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaCamera.Location", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaCamera", 
		NodeName = "Location", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaCamera", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Location : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Location);

		}
	}


	[NVP_Manifest(
		Id = "1A5D50B2-4F8C-4FC2-A23B-C5C3D9ABD13E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaCamera.Set_Location", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaCamera", 
		NodeName = "Set_Location", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaCamera", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_Location : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Location = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "EB69D5F9-40C2-4F25-BD46-1E12721F2986", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaCamera.Target", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaCamera", 
		NodeName = "Target", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaCamera", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Target : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Target);

		}
	}


	[NVP_Manifest(
		Id = "F2EB5C1B-79BD-4155-AF6E-1C520B7C3D91", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaCamera.Set_Target", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaCamera", 
		NodeName = "Set_Target", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaCamera", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_Target : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Target = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "82604481-6D2A-4085-855E-B43BA6E83D1B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaCamera.LensLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaCamera", 
		NodeName = "LensLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaCamera", typeof(object))]

	///<summary>
	///
	///</summary>
	public class LensLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LensLength);

		}
	}


	[NVP_Manifest(
		Id = "90EC78C0-6EFC-4B11-932D-AF3FA6D8504D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaCamera.Set_LensLength", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaCamera", 
		NodeName = "Set_LensLength", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaCamera", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_LensLength : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LensLength = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "B20B63CA-3274-41E6-B01E-3CA840F4A30A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaCamera.FieldOfView", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaCamera", 
		NodeName = "FieldOfView", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaCamera", typeof(object))]

	///<summary>
	///
	///</summary>
	public class FieldOfView : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FieldOfView);

		}
	}


	[NVP_Manifest(
		Id = "1F6FF9D4-F9D3-49AF-BCB7-8FFED0FC5BA3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaCamera.Set_FieldOfView", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaCamera", 
		NodeName = "Set_FieldOfView", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaCamera", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_FieldOfView : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FieldOfView = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8985B8F8-37B9-4DAF-83B7-A7BA2B90CE2B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaCamera.FrameHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaCamera", 
		NodeName = "FrameHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaCamera", typeof(object))]

	///<summary>
	///
	///</summary>
	public class FrameHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FrameHeight);

		}
	}


	[NVP_Manifest(
		Id = "EB01493A-3226-493D-8D69-6DAAE5140A60", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaCamera.Set_FrameHeight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaCamera", 
		NodeName = "Set_FrameHeight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaCamera", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class Set_FrameHeight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FrameHeight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D5A5EC04-831C-47DD-A457-019B2FC39639", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaCamera.FrameWidth", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaCamera", 
		NodeName = "FrameWidth", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaCamera", typeof(object))]

	///<summary>
	///
	///</summary>
	public class FrameWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FrameWidth);

		}
	}


	[NVP_Manifest(
		Id = "03D82019-EB64-4785-A23E-877354DBDEDF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaCamera.Set_FrameWidth", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaCamera", 
		NodeName = "Set_FrameWidth", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaCamera", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class Set_FrameWidth : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FrameWidth = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C6CEEDF9-CC33-4FCA-B7ED-9EAD938DE603", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaCamera.RollAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaCamera", 
		NodeName = "RollAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaCamera", typeof(object))]

	///<summary>
	///
	///</summary>
	public class RollAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.RollAngle);

		}
	}


	[NVP_Manifest(
		Id = "71798B80-91F5-469B-927A-4E5517221B5E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaCamera.Set_RollAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaCamera", 
		NodeName = "Set_RollAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaCamera", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_RollAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RollAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A84C5CDB-7247-4375-A830-D54EACA59DE9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaCamera.IsPlotable", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaCamera", 
		NodeName = "IsPlotable", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaCamera", typeof(object))]

	///<summary>
	///
	///</summary>
	public class IsPlotable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.IsPlotable);

		}
	}


	[NVP_Manifest(
		Id = "1CC298A6-48A0-4F76-ADB9-1053CB0C7407", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaCamera.Set_IsPlotable", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaCamera", 
		NodeName = "Set_IsPlotable", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaCamera", typeof(object))]
	[NodeInput("pVal", typeof(System.Object))]

	///<summary>
	///
	///</summary>
	public class Set_IsPlotable : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.IsPlotable = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "EB4DA516-F01E-4A49-831A-A8557DF1436B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaCamera.FrontPlane", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaCamera", 
		NodeName = "FrontPlane", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaCamera", typeof(object))]

	///<summary>
	///
	///</summary>
	public class FrontPlane : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.FrontPlane);

		}
	}


	[NVP_Manifest(
		Id = "447BBBE1-BBF2-4BFB-9090-2113B5FDAC62", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaCamera.Set_FrontPlane", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaCamera", 
		NodeName = "Set_FrontPlane", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaCamera", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class Set_FrontPlane : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.FrontPlane = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "76D8322A-4BBA-4B36-88C4-4FBA004EE765", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaCamera.BackPlane", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaCamera", 
		NodeName = "BackPlane", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaCamera", typeof(object))]

	///<summary>
	///
	///</summary>
	public class BackPlane : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.BackPlane);

		}
	}


	[NVP_Manifest(
		Id = "FD1713D7-DDB0-40A4-B2A3-B734DD2AB0A4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaCamera.Set_BackPlane", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaCamera", 
		NodeName = "Set_BackPlane", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaCamera", typeof(object))]
	[NodeInput("pVal", typeof(System.Double))]

	///<summary>
	///
	///</summary>
	public class Set_BackPlane : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.BackPlane = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E9E6C209-51B7-439A-AD16-D94F64510FB6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaCamera.Clipping", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaCamera", 
		NodeName = "Clipping", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Data")]
	[NodeInput("OdaCamera", typeof(object))]

	///<summary>
	///
	///</summary>
	public class Clipping : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Clipping);

		}
	}


	[NVP_Manifest(
		Id = "DAB8F0D9-6518-431B-9F18-B019A926F831", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.OdaCamera.Set_Clipping", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.OdaCamera", 
		NodeName = "Set_Clipping", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("OdaCamera", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///
	///</summary>
	public class Set_Clipping : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Clipping = inputs[1].Value;
			return null;
		}
	}
}
