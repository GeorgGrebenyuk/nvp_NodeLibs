using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a bounded area that displays some portion of a drawing's model space
///</summary>
namespace OdaX.AcadViewport 
{

	[NVP_Manifest(
		Id = "A9D2A2AE-C052-419C-9D46-0D00B657A94A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewport.AcadViewport_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewport", 
		NodeName = "_AcadViewport_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadViewport_Constructor : INode 
	{
		public OdaX.IAcadViewport _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadViewport;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "A3A473C1-73B5-4AE8-AF99-17648DA6FAD2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewport.AcadViewport_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewport", 
		NodeName = "_AcadViewport_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadViewport_ConstructorCast : INode 
	{
		public OdaX.IAcadViewport _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadViewport;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "83CC2743-9D4D-4D83-ABCE-908726516F3C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewport.Center", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewport", 
		NodeName = "Center", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the center of an arc, circle, ellipse, view, or viewport", 
		ViewType = "Data")]
	[NodeInput("AcadViewport", typeof(object))]

	///<summary>
	///Specifies the center of an arc, circle, ellipse, view, or viewport
	///</summary>
	public class Center : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Center);

		}
	}


	[NVP_Manifest(
		Id = "751D954C-5716-415D-BD26-EB5D4E4F6976", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewport.Set_Center", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewport", 
		NodeName = "Set_Center", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the center of an arc, circle, ellipse, view, or viewport", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewport", typeof(object))]
	[NodeInput("Center", typeof(System.Object))]

	///<summary>
	///Specifies the center of an arc, circle, ellipse, view, or viewport
	///</summary>
	public class Set_Center : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Center = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "649351BF-D634-44AA-9F4F-88875949A9C6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewport.Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewport", 
		NodeName = "Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Height of the attribute, shape, text, or view toolbar or the main application window", 
		ViewType = "Data")]
	[NodeInput("AcadViewport", typeof(object))]

	///<summary>
	///Height of the attribute, shape, text, or view toolbar or the main application window
	///</summary>
	public class Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Height);

		}
	}


	[NVP_Manifest(
		Id = "86E92959-EE7F-4F17-9231-4E53D43753B3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewport.Set_Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewport", 
		NodeName = "Set_Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Height of the attribute, shape, text, or view toolbar or the main application window", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewport", typeof(object))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Height of the attribute, shape, text, or view toolbar or the main application window
	///</summary>
	public class Set_Height : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Height = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "97CF23F7-EFFE-4786-8146-9EF758D70C30", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewport.Width", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewport", 
		NodeName = "Width", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the width of the text boundary, view, image, toolbar, or main application window", 
		ViewType = "Data")]
	[NodeInput("AcadViewport", typeof(object))]

	///<summary>
	///Specifies the width of the text boundary, view, image, toolbar, or main application window
	///</summary>
	public class Width : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Width);

		}
	}


	[NVP_Manifest(
		Id = "99ACDBF9-D3FF-4184-A157-0E2BA94DF9A2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewport.Set_Width", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewport", 
		NodeName = "Set_Width", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the width of the text boundary, view, image, toolbar, or main application window", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewport", typeof(object))]
	[NodeInput("Width", typeof(System.Double))]

	///<summary>
	///Specifies the width of the text boundary, view, image, toolbar, or main application window
	///</summary>
	public class Set_Width : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Width = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "72436A0A-FFA1-41FB-B0F7-1B8D0168FD43", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewport.Target", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewport", 
		NodeName = "Target", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the target point for the view or viewport", 
		ViewType = "Data")]
	[NodeInput("AcadViewport", typeof(object))]

	///<summary>
	///Specifies the target point for the view or viewport
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
		Id = "37E28BAD-919C-4327-B2E4-4AA25C43A8DC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewport.Set_Target", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewport", 
		NodeName = "Set_Target", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the target point for the view or viewport", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewport", typeof(object))]
	[NodeInput("targetPoint", typeof(System.Object))]

	///<summary>
	///Specifies the target point for the view or viewport
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
		Id = "F2FC07DE-6C85-4936-8D74-9FB17B78D107", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewport.Direction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewport", 
		NodeName = "Direction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the viewing direction for a 3D visualization of the drawing", 
		ViewType = "Data")]
	[NodeInput("AcadViewport", typeof(object))]

	///<summary>
	///Specifies the viewing direction for a 3D visualization of the drawing
	///</summary>
	public class Direction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Direction);

		}
	}


	[NVP_Manifest(
		Id = "22FB2A31-E497-4B7C-BAB4-EE5C7397A7B8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewport.Set_Direction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewport", 
		NodeName = "Set_Direction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the viewing direction for a 3D visualization of the drawing", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewport", typeof(object))]
	[NodeInput("dirVec", typeof(System.Object))]

	///<summary>
	///Specifies the viewing direction for a 3D visualization of the drawing
	///</summary>
	public class Set_Direction : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Direction = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "EF502FBA-2252-4780-B2F6-CE364583D913", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewport.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewport", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the name of the object", 
		ViewType = "Data")]
	[NodeInput("AcadViewport", typeof(object))]

	///<summary>
	///Specifies the name of the object
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
		Id = "87D80B55-5E2C-4CB1-B056-8BF20296D8E9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewport.Set_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewport", 
		NodeName = "Set_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the name of the object", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewport", typeof(object))]
	[NodeInput("bstrName", typeof(System.String))]

	///<summary>
	///Specifies the name of the object
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
		Id = "4A5CDF7C-99E8-4CCE-84F6-AC0ADDB7C6B7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewport.GridOn", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewport", 
		NodeName = "GridOn", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the status of the viewport grid", 
		ViewType = "Data")]
	[NodeInput("AcadViewport", typeof(object))]

	///<summary>
	///Specifies the status of the viewport grid
	///</summary>
	public class GridOn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.GridOn);

		}
	}


	[NVP_Manifest(
		Id = "6C033BFA-DC8E-477F-8237-D96D1E8D44D9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewport.Set_GridOn", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewport", 
		NodeName = "Set_GridOn", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the status of the viewport grid", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewport", typeof(object))]
	[NodeInput("bGridOn", typeof(System.Object))]

	///<summary>
	///Specifies the status of the viewport grid
	///</summary>
	public class Set_GridOn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GridOn = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7A362AA6-92D9-4E9C-9DBE-62A535FEE003", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewport.OrthoOn", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewport", 
		NodeName = "OrthoOn", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the status of the Ortho mode for the viewport", 
		ViewType = "Data")]
	[NodeInput("AcadViewport", typeof(object))]

	///<summary>
	///Specifies the status of the Ortho mode for the viewport
	///</summary>
	public class OrthoOn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.OrthoOn);

		}
	}


	[NVP_Manifest(
		Id = "DA1D9794-584F-408C-BCAB-53C60A7BF99F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewport.Set_OrthoOn", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewport", 
		NodeName = "Set_OrthoOn", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the status of the Ortho mode for the viewport", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewport", typeof(object))]
	[NodeInput("bOrthoOn", typeof(System.Object))]

	///<summary>
	///Specifies the status of the Ortho mode for the viewport
	///</summary>
	public class Set_OrthoOn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.OrthoOn = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "07C421D9-BE14-47C2-9E84-44CCCD381CD5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewport.SnapBasePoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewport", 
		NodeName = "SnapBasePoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the snap base point for the viewport", 
		ViewType = "Data")]
	[NodeInput("AcadViewport", typeof(object))]

	///<summary>
	///Specifies the snap base point for the viewport
	///</summary>
	public class SnapBasePoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SnapBasePoint);

		}
	}


	[NVP_Manifest(
		Id = "D9C12186-5155-41A1-B3B9-CD6C0EE33C4B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewport.Set_SnapBasePoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewport", 
		NodeName = "Set_SnapBasePoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the snap base point for the viewport", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewport", typeof(object))]
	[NodeInput("lowLeft", typeof(System.Object))]

	///<summary>
	///Specifies the snap base point for the viewport
	///</summary>
	public class Set_SnapBasePoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SnapBasePoint = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "C9E90730-93C1-427C-B048-70AD2EEF20F9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewport.SnapOn", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewport", 
		NodeName = "SnapOn", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the status of snap", 
		ViewType = "Data")]
	[NodeInput("AcadViewport", typeof(object))]

	///<summary>
	///Specifies the status of snap
	///</summary>
	public class SnapOn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SnapOn);

		}
	}


	[NVP_Manifest(
		Id = "5E7FD92B-D7ED-4CE9-B4DD-802469A132AD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewport.Set_SnapOn", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewport", 
		NodeName = "Set_SnapOn", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the status of snap", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewport", typeof(object))]
	[NodeInput("bSnapOn", typeof(System.Object))]

	///<summary>
	///Specifies the status of snap
	///</summary>
	public class Set_SnapOn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SnapOn = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1BD1984C-A655-46FD-B760-E73C7308E29A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewport.SnapRotationAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewport", 
		NodeName = "SnapRotationAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the snap rotation angle of the viewport relative to the current UCS", 
		ViewType = "Data")]
	[NodeInput("AcadViewport", typeof(object))]

	///<summary>
	///Specifies the snap rotation angle of the viewport relative to the current UCS
	///</summary>
	public class SnapRotationAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.SnapRotationAngle);

		}
	}


	[NVP_Manifest(
		Id = "5E32C3F6-6D7E-4B4D-826E-AED08B1E4F62", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewport.Set_SnapRotationAngle", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewport", 
		NodeName = "Set_SnapRotationAngle", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the snap rotation angle of the viewport relative to the current UCS", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewport", typeof(object))]
	[NodeInput("Angle", typeof(System.Object))]

	///<summary>
	///Specifies the snap rotation angle of the viewport relative to the current UCS
	///</summary>
	public class Set_SnapRotationAngle : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SnapRotationAngle = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "365A20F9-1B1B-4378-9891-4883811C14B4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewport.UCSIconOn", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewport", 
		NodeName = "UCSIconOn", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies if the UCS icon is on", 
		ViewType = "Data")]
	[NodeInput("AcadViewport", typeof(object))]

	///<summary>
	///Specifies if the UCS icon is on
	///</summary>
	public class UCSIconOn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UCSIconOn);

		}
	}


	[NVP_Manifest(
		Id = "F8381857-C1DB-47FF-AC49-A1E4D64683DF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewport.Set_UCSIconOn", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewport", 
		NodeName = "Set_UCSIconOn", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies if the UCS icon is on", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewport", typeof(object))]
	[NodeInput("bIconOn", typeof(System.Object))]

	///<summary>
	///Specifies if the UCS icon is on
	///</summary>
	public class Set_UCSIconOn : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UCSIconOn = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0B31760D-D34D-45F8-AB7B-6C0EC58FB9A9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewport.UCSIconAtOrigin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewport", 
		NodeName = "UCSIconAtOrigin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies if the UCS icon is displayed at the origin", 
		ViewType = "Data")]
	[NodeInput("AcadViewport", typeof(object))]

	///<summary>
	///Specifies if the UCS icon is displayed at the origin
	///</summary>
	public class UCSIconAtOrigin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UCSIconAtOrigin);

		}
	}


	[NVP_Manifest(
		Id = "E040B883-4BA6-4E8C-9891-19890F771CC6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewport.Set_UCSIconAtOrigin", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewport", 
		NodeName = "Set_UCSIconAtOrigin", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies if the UCS icon is displayed at the origin", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewport", typeof(object))]
	[NodeInput("bIconAtOrigin", typeof(System.Object))]

	///<summary>
	///Specifies if the UCS icon is displayed at the origin
	///</summary>
	public class Set_UCSIconAtOrigin : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.UCSIconAtOrigin = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A904C80E-DF1F-4B1F-A89B-08F8557E1362", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewport.LowerLeftCorner", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewport", 
		NodeName = "LowerLeftCorner", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the lower-left corner of the current active viewport", 
		ViewType = "Data")]
	[NodeInput("AcadViewport", typeof(object))]

	///<summary>
	///Gets the lower-left corner of the current active viewport
	///</summary>
	public class LowerLeftCorner : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LowerLeftCorner);

		}
	}


	[NVP_Manifest(
		Id = "299FE104-85DA-4B9E-9BB7-E8E7F2CBF5CE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewport.UpperRightCorner", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewport", 
		NodeName = "UpperRightCorner", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the upper-right corner of the current active viewport", 
		ViewType = "Data")]
	[NodeInput("AcadViewport", typeof(object))]

	///<summary>
	///Gets the upper-right corner of the current active viewport
	///</summary>
	public class UpperRightCorner : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.UpperRightCorner);

		}
	}


	[NVP_Manifest(
		Id = "BACE8EE9-DC91-472A-B47F-8DE476848CED", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewport.Split", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewport", 
		NodeName = "Split", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Splits a viewport into the given number of views", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewport", typeof(object))]
	[NodeInput("OdaX.AcViewportSplitType", typeof(System.Object))]

	///<summary>
	///Splits a viewport into the given number of views
	///</summary>
	public class Split : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Split(((OdaX.AcViewportSplitType)inputs[1].Value));
			return null;
		}
	}


	[NVP_Manifest(
		Id = "62C24C72-EC12-4D87-957E-8609CCD4D44B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewport.GetGridSpacing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewport", 
		NodeName = "GetGridSpacing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the grid spacing for the viewport", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewport", typeof(object))]
	[NodeInput("XSpacing", typeof(System.Double))]
	[NodeInput("YSpacing", typeof(System.Double))]

	///<summary>
	///Gets the grid spacing for the viewport
	///</summary>
	public class GetGridSpacing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetGridSpacing(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "767B3BA6-7C31-418C-AA8F-11DF9491B5D5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewport.SetGridSpacing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewport", 
		NodeName = "SetGridSpacing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the grid spacing for the viewport", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewport", typeof(object))]
	[NodeInput("XSpacing", typeof(System.Double))]
	[NodeInput("YSpacing", typeof(System.Double))]

	///<summary>
	///Sets the grid spacing for the viewport
	///</summary>
	public class SetGridSpacing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetGridSpacing(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "A632D52B-8E50-43D6-BFDF-14EFB5519AB0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewport.GetSnapSpacing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewport", 
		NodeName = "GetSnapSpacing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the snap spacing for the viewport", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewport", typeof(object))]
	[NodeInput("XSpacing", typeof(System.Double))]
	[NodeInput("YSpacing", typeof(System.Double))]

	///<summary>
	///Gets the snap spacing for the viewport
	///</summary>
	public class GetSnapSpacing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetSnapSpacing(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "F0188C61-6C69-4766-AC5E-EE6B2ADF8C36", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewport.SetSnapSpacing", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewport", 
		NodeName = "SetSnapSpacing", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the snap spacing for the viewport", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewport", typeof(object))]
	[NodeInput("XSpacing", typeof(System.Double))]
	[NodeInput("YSpacing", typeof(System.Double))]

	///<summary>
	///Sets the snap spacing for the viewport
	///</summary>
	public class SetSnapSpacing : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetSnapSpacing(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "73095345-62D3-4AA1-9247-CBB7BD42F964", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewport.SetView", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewport", 
		NodeName = "SetView", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the view in a viewport to a saved view in the Views Collection object", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewport", typeof(object))]
	[NodeInput("View", typeof(System.Object))]

	///<summary>
	///Sets the view in a viewport to a saved view in the Views Collection object
	///</summary>
	public class SetView : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SetView(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "7B5EC5B4-65F0-4C1F-B550-1A6EF550FEC9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewport.ArcSmoothness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewport", 
		NodeName = "ArcSmoothness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the smoothness of circles, arcs, and ellipses", 
		ViewType = "Data")]
	[NodeInput("AcadViewport", typeof(object))]

	///<summary>
	///Specifies the smoothness of circles, arcs, and ellipses
	///</summary>
	public class ArcSmoothness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.ArcSmoothness);

		}
	}


	[NVP_Manifest(
		Id = "2CA02615-F2F0-40FB-8267-FF8FDBEEA9FB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadViewport.Set_ArcSmoothness", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadViewport", 
		NodeName = "Set_ArcSmoothness", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the smoothness of circles, arcs, and ellipses", 
		ViewType = "Modifier")]
	[NodeInput("AcadViewport", typeof(object))]
	[NodeInput("arcSmooth", typeof(System.Object))]

	///<summary>
	///Specifies the smoothness of circles, arcs, and ellipses
	///</summary>
	public class Set_ArcSmoothness : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.ArcSmoothness = inputs[1].Value;
			return null;
		}
	}
}
