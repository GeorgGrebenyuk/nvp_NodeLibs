using NVP.API.Nodes;

using NVP_Manifest_Creator;

///<summary>
///A group of one or more objects specified for processing as a single unit
///</summary>
namespace nanoCAD.nanoCADSelectionSet 
{

	[NVP_Manifest(
		Id = "09EBFC20-5698-4B98-AB6E-12A378E807BE", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADSelectionSet.nanoCADSelectionSet_Constructor", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADSelectionSet", 
		NodeName = "_nanoCADSelectionSet_Constructor", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADSelectionSet_Constructor : INode 
	{
		public nanoCAD.InanoCADSelectionSet _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0 as nanoCAD.InanoCADSelectionSet;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}

	[NVP_Manifest(
		Id = "8C5AB1E4-6E3B-43C5-B396-99DB359E33DD", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADSelectionSet.nanoCADSelectionSet_ConstructorCast", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADSelectionSet", 
		NodeName = "_nanoCADSelectionSet_ConstructorCast", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "", 
		ViewType = "Modifier")]
	[NodeInput("dynamic", typeof(object))]
	public class nanoCADSelectionSet_ConstructorCast : INode 
	{
		public nanoCAD.InanoCADSelectionSet _i;
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			this._i = _input0._i as nanoCAD.InanoCADSelectionSet;
			if (this._i == null) throw new Exception("Invalid casting");
			return new NodeResult(this);
		}
	}


	[NVP_Manifest(
		Id = "92A22A41-1E89-4605-A609-247B80E3CDC4", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADSelectionSet.Item", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADSelectionSet", 
		NodeName = "Item", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the member object at a given index in a collection, group, or selection set", 
		ViewType = "Data")]
	[NodeInput("nanoCADSelectionSet", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]

	///<summary>
	///Gets the member object at a given index in a collection, group, or selection set
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
		Id = "96003BB9-21A8-4C03-9A14-4354D0F23AF9", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADSelectionSet.Count", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADSelectionSet", 
		NodeName = "Count", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the number of items in the collection, dictionary, group, or selection set", 
		ViewType = "Data")]
	[NodeInput("nanoCADSelectionSet", typeof(object))]

	///<summary>
	///Gets the number of items in the collection, dictionary, group, or selection set
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
		Id = "391A590C-A589-4F6D-8C1A-4411F7F2BF78", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADSelectionSet.Name", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADSelectionSet", 
		NodeName = "Name", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Specifies the name of the object", 
		ViewType = "Data")]
	[NodeInput("nanoCADSelectionSet", typeof(object))]

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
		Id = "6AC86EB3-4851-407B-AFDB-778F58D58A13", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADSelectionSet.Highlight", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADSelectionSet", 
		NodeName = "Highlight", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Sets the highlight status for the given object, or for all objects in a given selection set", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADSelectionSet", typeof(object))]
	[NodeInput("bFlag", typeof(System.Object))]

	///<summary>
	///Sets the highlight status for the given object, or for all objects in a given selection set
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
		Id = "E087C953-CBD4-4F7F-B727-A0B36F23912B", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADSelectionSet.Erase", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADSelectionSet", 
		NodeName = "Erase", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Erases all the objects in a selection set", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADSelectionSet", typeof(object))]

	///<summary>
	///Erases all the objects in a selection set
	///</summary>
	public class Erase : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Erase();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "D1BFA4FC-BF28-4E5E-A6A0-C5E47AA69EF5", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADSelectionSet.Update", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADSelectionSet", 
		NodeName = "Update", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Updates the object to the drawing screen", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADSelectionSet", typeof(object))]

	///<summary>
	///Updates the object to the drawing screen
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
		Id = "983B6397-5383-4AD4-9DD5-877D0AC560AC", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADSelectionSet.Application", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADSelectionSet", 
		NodeName = "Application", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Gets the Application object", 
		ViewType = "Data")]
	[NodeInput("nanoCADSelectionSet", typeof(object))]

	///<summary>
	///Gets the Application object
	///</summary>
	public class Application : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Application);

		}
	}


	[NVP_Manifest(
		Id = "D5B71E87-05F8-46F5-A46E-6D77846B7D5A", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADSelectionSet.AddItems", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADSelectionSet", 
		NodeName = "AddItems", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Adds one or more objects to the specified selection set", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADSelectionSet", typeof(object))]
	[NodeInput("pSelSet", typeof(System.Object))]

	///<summary>
	///Adds one or more objects to the specified selection set
	///</summary>
	public class AddItems : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddItems(inputs[1].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "2BF81CC4-E52D-4D4C-91CB-6F8BBE1361DB", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADSelectionSet.RemoveItems", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADSelectionSet", 
		NodeName = "RemoveItems", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Removes specified items from the group or selection set", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADSelectionSet", typeof(object))]
	[NodeInput("Objects", typeof(System.Object))]

	///<summary>
	///Removes specified items from the group or selection set
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
		Id = "695C3FD1-ACF8-47E1-A640-552D5C1E4567", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADSelectionSet.Clear", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADSelectionSet", 
		NodeName = "Clear", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Clears the specified selection set of all items", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADSelectionSet", typeof(object))]

	///<summary>
	///Clears the specified selection set of all items
	///</summary>
	public class Clear : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Clear();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "726292BB-EE9F-40FA-ABA9-B03657FBB5AA", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADSelectionSet.Select", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADSelectionSet", 
		NodeName = "Select", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Selects objects and places them into a selection set", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADSelectionSet", typeof(object))]
	[NodeInput("nanoCAD.AcSelect", typeof(System.Object))]
	[NodeInput("Point1", typeof(System.Object))]
	[NodeInput("Point2", typeof(System.Object))]
	[NodeInput("FilterType", typeof(System.Object))]
	[NodeInput("FilterData", typeof(System.Object))]

	///<summary>
	///Selects objects and places them into a selection set
	///</summary>
	public class Select : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Select(((nanoCAD.AcSelect)inputs[1].Value),inputs[2].Value,inputs[3].Value,inputs[4].Value,inputs[5].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "0EEE7DE3-4D94-45AD-91C4-E29FEAC10AF7", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADSelectionSet.SelectAtPoint", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADSelectionSet", 
		NodeName = "SelectAtPoint", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Selects an object passing through a given point and places it into a selection set", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADSelectionSet", typeof(object))]
	[NodeInput("Point", typeof(System.Object))]
	[NodeInput("FilterType", typeof(System.Object))]
	[NodeInput("FilterData", typeof(System.Object))]

	///<summary>
	///Selects an object passing through a given point and places it into a selection set
	///</summary>
	public class SelectAtPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SelectAtPoint(inputs[1].Value,inputs[2].Value,inputs[3].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "61CB2C35-495A-4903-BAD8-D16C4885D297", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADSelectionSet.SelectByPolygon", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADSelectionSet", 
		NodeName = "SelectByPolygon", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Selects entities within a fence and adds them to the selection set", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADSelectionSet", typeof(object))]
	[NodeInput("nanoCAD.AcSelect", typeof(System.Object))]
	[NodeInput("PointsList", typeof(System.Object))]
	[NodeInput("FilterType", typeof(System.Object))]
	[NodeInput("FilterData", typeof(System.Object))]

	///<summary>
	///Selects entities within a fence and adds them to the selection set
	///</summary>
	public class SelectByPolygon : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SelectByPolygon(((nanoCAD.AcSelect)inputs[1].Value),inputs[2].Value,inputs[3].Value,inputs[4].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "461A4560-4093-4BE2-BF5A-641D837493A8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADSelectionSet.SelectOnScreen", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADSelectionSet", 
		NodeName = "SelectOnScreen", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Prompts the user to pick an object from the screen", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADSelectionSet", typeof(object))]
	[NodeInput("FilterType", typeof(System.Object))]
	[NodeInput("FilterData", typeof(System.Object))]

	///<summary>
	///Prompts the user to pick an object from the screen
	///</summary>
	public class SelectOnScreen : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SelectOnScreen(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}


	[NVP_Manifest(
		Id = "008AE81D-E8A5-4E2E-8086-66451B8FBCE8", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADSelectionSet.Delete", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADSelectionSet", 
		NodeName = "Delete", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Deletes a specified object", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADSelectionSet", typeof(object))]

	///<summary>
	///Deletes a specified object
	///</summary>
	public class Delete : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Delete();
			return null;
		}
	}


	[NVP_Manifest(
		Id = "5BC920E3-DD17-4A3B-8CF7-CEB75B80CBC2", 
		PathAssembly = "NVP_nanoCAD_COM.dll", 
		PathExecuteClass = "nanoCAD.nanoCADSelectionSet.GetBoundingBox", 
		CoderName = "GeorgGrebenyuk", 
		Folder = "NVP_nanoCAD_COM.nanoCAD.nanoCADSelectionSet", 
		NodeName = "GetBoundingBox", 
		NodeType = "Loaded", 
		CADType = "None", 
		Text = "Calculates the bounding box of selection", 
		ViewType = "Modifier")]
	[NodeInput("nanoCADSelectionSet", typeof(object))]
	[NodeInput("MinPoint", typeof(System.Object))]
	[NodeInput("MaxPoint", typeof(System.Object))]

	///<summary>
	///Calculates the bounding box of selection
	///</summary>
	public class GetBoundingBox : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetBoundingBox(inputs[1].Value,inputs[2].Value);
			return null;
		}
	}
}
