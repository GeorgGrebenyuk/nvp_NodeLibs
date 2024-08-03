using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///TeighaX Interface of a named SelectionSet object
///</summary>
namespace OdaX.AcadGroup 
{

	[NVP_Manifest(
		Id = "A9C0B7DC-B00A-411C-B091-9B7D0D330FA3", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadGroup.AcadGroup_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadGroup", 
		NodeName = "_AcadGroup_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadGroup_Constructor : INode 
	{
		public OdaX.IAcadGroup _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as OdaX.IAcadGroup;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "B493EFD4-A284-4E15-A265-E514DA89090D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadGroup.AcadGroup_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadGroup", 
		NodeName = "_AcadGroup_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class AcadGroup_ConstructorCast : INode 
	{
		public OdaX.IAcadGroup _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as OdaX.IAcadGroup;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "492E7231-5586-4AA7-A334-55B426ADC73D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadGroup.Item", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadGroup", 
		NodeName = "Item", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns an object at a given index in the group.", 
		ViewType = "Data")]
	[NodeInput("AcadGroup", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///Returns an object at a given index in the group.
	///</summary>
	public class Item : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Item(inputs[1].Value));

		}
	}


	[NVP_Manifest(
		Id = "8EF8B57E-8FD8-4DCE-8731-285842A06A97", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadGroup.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadGroup", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Returns the number of items in the group.", 
		ViewType = "Data")]
	[NodeInput("AcadGroup", typeof(object))]

	///<summary>
	///Returns the number of items in the group.
	///</summary>
	public class Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Count);

		}
	}


	[NVP_Manifest(
		Id = "E2F9F549-2341-4D5D-B416-BD74DC075574", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadGroup.Set_TrueColor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadGroup", 
		NodeName = "Set_TrueColor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the true color of all entities in the group.", 
		ViewType = "Modifier")]
	[NodeInput("AcadGroup", typeof(object))]
	[NodeInput("rhs", typeof(System.Object))]

	///<summary>
	///Specifies the true color of all entities in the group.
	///</summary>
	public class Set_TrueColor : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.TrueColor = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "42BE2F3B-E426-4B7A-BEB9-D5FF6C883B0A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadGroup.Set_Layer", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadGroup", 
		NodeName = "Set_Layer", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the layer of all entites in the group.", 
		ViewType = "Modifier")]
	[NodeInput("AcadGroup", typeof(object))]
	[NodeInput("rhs", typeof(System.String))]

	///<summary>
	///Specifies the layer of all entites in the group.
	///</summary>
	public class Set_Layer : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Layer = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3A29D99C-E42A-4D9B-9DD0-D5814D87DF72", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadGroup.Set_Linetype", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadGroup", 
		NodeName = "Set_Linetype", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the linetype of all entites in the group.", 
		ViewType = "Modifier")]
	[NodeInput("AcadGroup", typeof(object))]
	[NodeInput("rhs", typeof(System.String))]

	///<summary>
	///Specifies the linetype of all entites in the group.
	///</summary>
	public class Set_Linetype : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Linetype = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5C22211F-74C1-4336-A9C2-0C3A2F4B502A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadGroup.Set_LinetypeScale", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadGroup", 
		NodeName = "Set_LinetypeScale", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the linetype scale of all entites in the group.", 
		ViewType = "Modifier")]
	[NodeInput("AcadGroup", typeof(object))]
	[NodeInput("rhs", typeof(System.Object))]

	///<summary>
	///Specifies the linetype scale of all entites in the group.
	///</summary>
	public class Set_LinetypeScale : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.LinetypeScale = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "1A3688FC-C8F5-42AD-ADEF-E8789E89BCC9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadGroup.Set_Visible", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadGroup", 
		NodeName = "Set_Visible", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the visibility of all entites in the group.", 
		ViewType = "Modifier")]
	[NodeInput("AcadGroup", typeof(object))]
	[NodeInput("rhs", typeof(System.Object))]

	///<summary>
	///Specifies the visibility of all entites in the group.
	///</summary>
	public class Set_Visible : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Visible = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "868C5FFB-507C-40A9-BC02-A09AD92D9BD7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadGroup.Highlight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadGroup", 
		NodeName = "Highlight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Not implemented. Sets the highlight status of all entites in the group.", 
		ViewType = "Modifier")]
	[NodeInput("AcadGroup", typeof(object))]
	[NodeInput("HighlightFlag", typeof(System.Object))]

	///<summary>
	///Not implemented. Sets the highlight status of all entites in the group.
	///</summary>
	public class Highlight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Highlight(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "AD2B7BE8-501E-4ECD-849D-EAB8EDA6922D", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadGroup.Set_PlotStyleName", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadGroup", 
		NodeName = "Set_PlotStyleName", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the plot style of all entites in the group.", 
		ViewType = "Modifier")]
	[NodeInput("AcadGroup", typeof(object))]
	[NodeInput("rhs", typeof(System.String))]

	///<summary>
	///Specifies the plot style of all entites in the group.
	///</summary>
	public class Set_PlotStyleName : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.PlotStyleName = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "683BE686-F6C5-4682-B929-44C3715E47B1", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadGroup.Set_Lineweight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadGroup", 
		NodeName = "Set_Lineweight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the lineweight of all entites in the group.", 
		ViewType = "Modifier")]
	[NodeInput("AcadGroup", typeof(object))]
	[NodeInput("rhs", typeof(System.Object))]

	///<summary>
	///Specifies the lineweight of all entites in the group.
	///</summary>
	public class Set_Lineweight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Lineweight = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8D2521B5-9BF8-4682-9A68-97D4E376078C", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadGroup.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadGroup", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the name of the group.", 
		ViewType = "Data")]
	[NodeInput("AcadGroup", typeof(object))]

	///<summary>
	///Specifies or returns the name of the group.
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
		Id = "45A7E4D3-D77F-4430-AF80-A77160CA643A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadGroup.Set_Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadGroup", 
		NodeName = "Set_Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies or returns the name of the group.", 
		ViewType = "Modifier")]
	[NodeInput("AcadGroup", typeof(object))]
	[NodeInput("pVal", typeof(System.String))]

	///<summary>
	///Specifies or returns the name of the group.
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
		Id = "20BF3250-CAE7-4343-9E9E-6257CFD41FF7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadGroup.AppendItems", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadGroup", 
		NodeName = "AppendItems", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Adds one or more objects to the group.", 
		ViewType = "Modifier")]
	[NodeInput("AcadGroup", typeof(object))]
	[NodeInput("Objects", typeof(System.Object))]

	///<summary>
	///Adds one or more objects to the group.
	///</summary>
	public class AppendItems : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AppendItems(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "E6F0F456-EC40-4195-8841-352FCA709349", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadGroup.RemoveItems", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadGroup", 
		NodeName = "RemoveItems", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Removes objects from the group.", 
		ViewType = "Modifier")]
	[NodeInput("AcadGroup", typeof(object))]
	[NodeInput("Objects", typeof(System.Object))]

	///<summary>
	///Removes objects from the group.
	///</summary>
	public class RemoveItems : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RemoveItems(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "3937EA10-1AE7-485A-BED9-7C3CAA2DC873", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadGroup.Update", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadGroup", 
		NodeName = "Update", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Updates the group on the screen.", 
		ViewType = "Modifier")]
	[NodeInput("AcadGroup", typeof(object))]

	///<summary>
	///Updates the group on the screen.
	///</summary>
	public class Update : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Update();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "ABBF2069-ABD8-4C3E-A5C7-CCF8F0BE7443", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadGroup.Set_Material", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadGroup", 
		NodeName = "Set_Material", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the material assigned to all entities in the group.", 
		ViewType = "Modifier")]
	[NodeInput("AcadGroup", typeof(object))]
	[NodeInput("rhs", typeof(System.String))]

	///<summary>
	///Specifies the material assigned to all entities in the group.
	///</summary>
	public class Set_Material : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Material = inputs[1].Value;
			return null;
		}
	}


	[NVP_Manifest(
		Id = "8E3401AD-36A4-4751-AAAE-F150A3B85CF5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "OdaX.AcadGroup.Set_color", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.OdaX.AcadGroup", 
		NodeName = "Set_color", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the color of all entities in the group.", 
		ViewType = "Modifier")]
	[NodeInput("AcadGroup", typeof(object))]
	[NodeInput("OdaX.AcColor", typeof(System.Object))]

	///<summary>
	///Specifies the color of all entities in the group.
	///</summary>
	public class Set_color : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.color = ((OdaX.AcColor)inputs[1].Value);
			return null;
		}
	}
}
