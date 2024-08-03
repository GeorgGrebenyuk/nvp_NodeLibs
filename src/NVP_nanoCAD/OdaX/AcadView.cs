using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///viewpoint) in space
///</summary>
namespace OdaX.AcadView 
{

	[NVP_Manifest(
		Id = "F715FFB9-6736-4EF5-A30E-AAEE124C6F34", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadView.AcadView_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadView", 
		NodeName = "_AcadView_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadView_Constructor : INode 
	{
		public OdaX.IAcadView _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadView;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "B0FFC644-E3EF-48E6-A88D-3C6F0FC4735F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadView.AcadView_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadView", 
		NodeName = "_AcadView_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadView_ConstructorCast : INode 
	{
		public OdaX.IAcadView _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadView;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "67DC9AF8-6976-421C-AF46-A52AD4913006", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadView.Center", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadView", 
		NodeName = "Center", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the center of an arc, circle, ellipse, view, or viewport", 
		ViewType = "Data")]
	[NodeInput("AcadView", typeof(object))]

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
		Id = "9AE87DE3-DE88-4C4A-8CDC-E5E31C7C6AEF", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadView.Set_Center", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadView", 
		NodeName = "Set_Center", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the center of an arc, circle, ellipse, view, or viewport", 
		ViewType = "Modifier")]
	[NodeInput("AcadView", typeof(object))]
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
		Id = "4BC8A493-3BD8-4416-A497-CD8678B065E2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadView.Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadView", 
		NodeName = "Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Height of the object", 
		ViewType = "Data")]
	[NodeInput("AcadView", typeof(object))]

	///<summary>
	///Height of the object
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
		Id = "19DEBF68-64BB-43C3-80D1-4AE75DB72DA6", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadView.Set_Height", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadView", 
		NodeName = "Set_Height", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Height of the object", 
		ViewType = "Modifier")]
	[NodeInput("AcadView", typeof(object))]
	[NodeInput("Height", typeof(System.Double))]

	///<summary>
	///Height of the object
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
		Id = "B6078D35-DD55-4DDF-948B-C2F68C8D0E79", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadView.Width", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadView", 
		NodeName = "Width", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the width of the object", 
		ViewType = "Data")]
	[NodeInput("AcadView", typeof(object))]

	///<summary>
	///Specifies the width of the object
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
		Id = "B9AFA592-C44F-48CB-A111-74D6F068ADF0", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadView.Set_Width", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadView", 
		NodeName = "Set_Width", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the width of the object", 
		ViewType = "Modifier")]
	[NodeInput("AcadView", typeof(object))]
	[NodeInput("Width", typeof(System.Double))]

	///<summary>
	///Specifies the width of the object
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
		Id = "4945F200-EF03-4771-B48B-49594DC5AE8E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadView.Target", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadView", 
		NodeName = "Target", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the target point for the view or viewport", 
		ViewType = "Data")]
	[NodeInput("AcadView", typeof(object))]

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
		Id = "9B1D9447-6A55-43D1-84E6-ED191692B59F", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadView.Set_Target", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadView", 
		NodeName = "Set_Target", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the target point for the view or viewport", 
		ViewType = "Modifier")]
	[NodeInput("AcadView", typeof(object))]
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
		Id = "CF1BCA40-E149-413C-811E-0611D6367EE3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadView.Direction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadView", 
		NodeName = "Direction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the viewing direction for a 3D visualization of the drawing", 
		ViewType = "Data")]
	[NodeInput("AcadView", typeof(object))]

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
		Id = "9B1B0F7A-651E-4B1F-BF34-5EA09B83749E", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadView.Set_Direction", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadView", 
		NodeName = "Set_Direction", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the viewing direction for a 3D visualization of the drawing", 
		ViewType = "Modifier")]
	[NodeInput("AcadView", typeof(object))]
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
		Id = "34827E51-A34A-4DD4-993A-7190CAE5CF3D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadView.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadView", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the name of the object", 
		ViewType = "Data")]
	[NodeInput("AcadView", typeof(object))]

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
		Id = "F8F79195-4A9A-4DE2-9707-309ECCE2F578", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadView.Set_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadView", 
		NodeName = "Set_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the name of the object", 
		ViewType = "Modifier")]
	[NodeInput("AcadView", typeof(object))]
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
		Id = "F79D1818-8CEC-4C53-8797-890D8265403D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadView.CategoryName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadView", 
		NodeName = "CategoryName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns and sets the name of the category of the view.", 
		ViewType = "Data")]
	[NodeInput("AcadView", typeof(object))]

	///<summary>
	///Returns and sets the name of the category of the view.
	///</summary>
	public class CategoryName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.CategoryName);

		}
	}


	[NVP_Manifest(
		Id = "1AF78C84-10D2-43A4-ACD5-045184ECEC7C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadView.Set_CategoryName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadView", 
		NodeName = "Set_CategoryName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns and sets the name of the category of the view.", 
		ViewType = "Modifier")]
	[NodeInput("AcadView", typeof(object))]
	[NodeInput("category", typeof(System.String))]

	///<summary>
	///Returns and sets the name of the category of the view.
	///</summary>
	public class Set_CategoryName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.CategoryName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "AE9744A7-6802-43F6-BF14-0149CA3F80B7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadView.LayoutId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadView", 
		NodeName = "LayoutId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns and sets the layout of the view.", 
		ViewType = "Data")]
	[NodeInput("AcadView", typeof(object))]

	///<summary>
	///Returns and sets the layout of the view.
	///</summary>
	public class LayoutId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LayoutId);

		}
	}


	[NVP_Manifest(
		Id = "8F960E50-DE2C-4CCB-B105-83092E87883A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadView.Set_LayoutId", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadView", 
		NodeName = "Set_LayoutId", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns and sets the layout of the view.", 
		ViewType = "Modifier")]
	[NodeInput("AcadView", typeof(object))]
	[NodeInput("ObjectID", typeof(System.Object))]

	///<summary>
	///Returns and sets the layout of the view.
	///</summary>
	public class Set_LayoutId : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LayoutId = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "42BF8066-34D2-40EB-81A9-8496AFDFA977", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadView.LayerState", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadView", 
		NodeName = "LayerState", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns and sets the name of the layer state of the view.", 
		ViewType = "Data")]
	[NodeInput("AcadView", typeof(object))]

	///<summary>
	///Returns and sets the name of the layer state of the view.
	///</summary>
	public class LayerState : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.LayerState);

		}
	}


	[NVP_Manifest(
		Id = "5DB9C9D3-236E-41ED-98E8-C0F2E61DE3E9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadView.Set_LayerState", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadView", 
		NodeName = "Set_LayerState", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns and sets the name of the layer state of the view.", 
		ViewType = "Modifier")]
	[NodeInput("AcadView", typeof(object))]
	[NodeInput("LayerState", typeof(System.String))]

	///<summary>
	///Returns and sets the name of the layer state of the view.
	///</summary>
	public class Set_LayerState : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LayerState = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "433DC8D8-4405-47C4-B2CF-72F044FB37E5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadView.HasVpAssociation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadView", 
		NodeName = "HasVpAssociation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies whether the view is associated with a paperspace viewport.", 
		ViewType = "Data")]
	[NodeInput("AcadView", typeof(object))]

	///<summary>
	///Specifies whether the view is associated with a paperspace viewport.
	///</summary>
	public class HasVpAssociation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.HasVpAssociation);

		}
	}


	[NVP_Manifest(
		Id = "88AC4BF0-FE32-4ABF-81B2-C923D3AFFE62", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadView.Set_HasVpAssociation", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadView", 
		NodeName = "Set_HasVpAssociation", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies whether the view is associated with a paperspace viewport.", 
		ViewType = "Modifier")]
	[NodeInput("AcadView", typeof(object))]
	[NodeInput("bVpAssoc", typeof(System.Object))]

	///<summary>
	///Specifies whether the view is associated with a paperspace viewport.
	///</summary>
	public class Set_HasVpAssociation : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.HasVpAssociation = inputs[1].Value;
			return null;
		}
	}
}
