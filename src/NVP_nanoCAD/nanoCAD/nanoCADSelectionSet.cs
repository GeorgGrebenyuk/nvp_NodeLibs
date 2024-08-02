using NVP.API.Nodes;

namespace nanoCAD.nanoCADSelectionSet 
{
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


	///<summary>
	///Gets the member object at a given index in a collection, group, or selection set
	///</summary>
	[NodeInput("nanoCADSelectionSet", typeof(object))]
	[NodeInput("Index", typeof(System.Object))]
	public class Item : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Item(inputs[1]));

		}
	}


	///<summary>
	///Gets the number of items in the collection, dictionary, group, or selection set
	///</summary>
	[NodeInput("nanoCADSelectionSet", typeof(object))]
	public class Count : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Count);

		}
	}


	///<summary>
	///Specifies the name of the object
	///</summary>
	[NodeInput("nanoCADSelectionSet", typeof(object))]
	public class Name : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Name);

		}
	}


	///<summary>
	///Sets the highlight status for the given object, or for all objects in a given selection set
	///</summary>
	[NodeInput("nanoCADSelectionSet", typeof(object))]
	[NodeInput("bFlag", typeof(System.Object))]
	public class Highlight : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Highlight(inputs[1]);
			return null;
		}
	}


	///<summary>
	///Erases all the objects in a selection set
	///</summary>
	[NodeInput("nanoCADSelectionSet", typeof(object))]
	public class Erase : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Erase();
			return null;
		}
	}


	///<summary>
	///Updates the object to the drawing screen
	///</summary>
	[NodeInput("nanoCADSelectionSet", typeof(object))]
	public class Update : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Update();
			return null;
		}
	}


	///<summary>
	///Gets the Application object
	///</summary>
	[NodeInput("nanoCADSelectionSet", typeof(object))]
	public class Application : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			return new NodeResult(_input0._i.Application);

		}
	}


	///<summary>
	///Adds one or more objects to the specified selection set
	///</summary>
	[NodeInput("nanoCADSelectionSet", typeof(object))]
	[NodeInput("pSelSet", typeof(System.Object))]
	public class AddItems : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.AddItems(inputs[1]);
			return null;
		}
	}


	///<summary>
	///Removes specified items from the group or selection set
	///</summary>
	[NodeInput("nanoCADSelectionSet", typeof(object))]
	[NodeInput("Objects", typeof(System.Object))]
	public class RemoveItems : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.RemoveItems(inputs[1]);
			return null;
		}
	}


	///<summary>
	///Clears the specified selection set of all items
	///</summary>
	[NodeInput("nanoCADSelectionSet", typeof(object))]
	public class Clear : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Clear();
			return null;
		}
	}


	///<summary>
	///Selects objects and places them into a selection set
	///</summary>
	[NodeInput("nanoCADSelectionSet", typeof(object))]
	[NodeInput("Mode", typeof(System.Object))]
	[NodeInput("Point1", typeof(System.Object))]
	[NodeInput("Point2", typeof(System.Object))]
	[NodeInput("FilterType", typeof(System.Object))]
	[NodeInput("FilterData", typeof(System.Object))]
	public class Select : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Select(inputs[1],inputs[2],inputs[3],inputs[4],inputs[5]);
			return null;
		}
	}


	///<summary>
	///Selects an object passing through a given point and places it into a selection set
	///</summary>
	[NodeInput("nanoCADSelectionSet", typeof(object))]
	[NodeInput("Point", typeof(System.Object))]
	[NodeInput("FilterType", typeof(System.Object))]
	[NodeInput("FilterData", typeof(System.Object))]
	public class SelectAtPoint : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SelectAtPoint(inputs[1],inputs[2],inputs[3]);
			return null;
		}
	}


	///<summary>
	///Selects entities within a fence and adds them to the selection set
	///</summary>
	[NodeInput("nanoCADSelectionSet", typeof(object))]
	[NodeInput("Mode", typeof(System.Object))]
	[NodeInput("PointsList", typeof(System.Object))]
	[NodeInput("FilterType", typeof(System.Object))]
	[NodeInput("FilterData", typeof(System.Object))]
	public class SelectByPolygon : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SelectByPolygon(inputs[1],inputs[2],inputs[3],inputs[4]);
			return null;
		}
	}


	///<summary>
	///Prompts the user to pick an object from the screen
	///</summary>
	[NodeInput("nanoCADSelectionSet", typeof(object))]
	[NodeInput("FilterType", typeof(System.Object))]
	[NodeInput("FilterData", typeof(System.Object))]
	public class SelectOnScreen : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.SelectOnScreen(inputs[1],inputs[2]);
			return null;
		}
	}


	///<summary>
	///Deletes a specified object
	///</summary>
	[NodeInput("nanoCADSelectionSet", typeof(object))]
	public class Delete : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.Delete();
			return null;
		}
	}


	///<summary>
	///Calculates the bounding box of selection
	///</summary>
	[NodeInput("nanoCADSelectionSet", typeof(object))]
	[NodeInput("MinPoint", typeof(System.Object))]
	[NodeInput("MaxPoint", typeof(System.Object))]
	public class GetBoundingBox : INode
	{
		public NodeResult Execute(INVPData context, List<NodeResult> inputs)
		{
			dynamic _input0 = inputs[0].Value;
			_input0._i.GetBoundingBox(inputs[1],inputs[2]);
			return null;
		}
	}
}
