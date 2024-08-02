using NVP.API.Nodes;

namespace OdaX.AcadLayer 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadLayer_Constructor : INode 
		{
		public OdaX.IAcadLayer _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadLayer;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadLayer_ConstructorCast : INode 
		{
		public OdaX.IAcadLayer _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadLayer;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Specifies or returns the color of a layer.
		///</summary>
		[NodeInput("AcadLayer", typeof(object))]
		public class color : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.color);

			}
		}


		///<summary>
		///Specifies or returns the color of a layer.
		///</summary>
		[NodeInput("AcadLayer", typeof(object))]
		[NodeInput("color", typeof(System.Object))]
		public class Set_color : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.color = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the true color of a layer.
		///</summary>
		[NodeInput("AcadLayer", typeof(object))]
		public class TrueColor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TrueColor);

			}
		}


		///<summary>
		///Specifies or returns the true color of a layer.
		///</summary>
		[NodeInput("AcadLayer", typeof(object))]
		[NodeInput("pColor", typeof(System.Object))]
		public class Set_TrueColor : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.TrueColor = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether objects on a layer are visible, editable, and printable.
		///</summary>
		[NodeInput("AcadLayer", typeof(object))]
		public class Freeze : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Freeze);

			}
		}


		///<summary>
		///Specifies or returns whether objects on a layer are visible, editable, and printable.
		///</summary>
		[NodeInput("AcadLayer", typeof(object))]
		[NodeInput("bFreeze", typeof(System.Object))]
		public class Set_Freeze : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Freeze = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether objects on a layer are visible and printable.
		///</summary>
		[NodeInput("AcadLayer", typeof(object))]
		public class LayerOn : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LayerOn);

			}
		}


		///<summary>
		///Specifies or returns whether objects on a layer are visible and printable.
		///</summary>
		[NodeInput("AcadLayer", typeof(object))]
		[NodeInput("bOn", typeof(System.Object))]
		public class Set_LayerOn : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.LayerOn = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the linetype of a layer.
		///</summary>
		[NodeInput("AcadLayer", typeof(object))]
		public class Linetype : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Linetype);

			}
		}


		///<summary>
		///Specifies or returns the linetype of a layer.
		///</summary>
		[NodeInput("AcadLayer", typeof(object))]
		[NodeInput("Linetype", typeof(System.String))]
		public class Set_Linetype : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Linetype = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether objects on a layer are editable.
		///</summary>
		[NodeInput("AcadLayer", typeof(object))]
		public class Lock : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Lock);

			}
		}


		///<summary>
		///Specifies or returns whether objects on a layer are editable.
		///</summary>
		[NodeInput("AcadLayer", typeof(object))]
		[NodeInput("Block", typeof(System.Object))]
		public class Set_Lock : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Lock = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the name of a layer.
		///</summary>
		[NodeInput("AcadLayer", typeof(object))]
		public class Name : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Name);

			}
		}


		///<summary>
		///Specifies or returns the name of a layer.
		///</summary>
		[NodeInput("AcadLayer", typeof(object))]
		[NodeInput("bstrName", typeof(System.String))]
		public class Set_Name : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Name = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether objects of a layer can be printed.
		///</summary>
		[NodeInput("AcadLayer", typeof(object))]
		public class Plottable : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Plottable);

			}
		}


		///<summary>
		///Specifies or returns whether objects of a layer can be printed.
		///</summary>
		[NodeInput("AcadLayer", typeof(object))]
		[NodeInput("bPlottable", typeof(System.Object))]
		public class Set_Plottable : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Plottable = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns whether the layer is frozen in new viewports.
		///</summary>
		[NodeInput("AcadLayer", typeof(object))]
		public class ViewportDefault : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ViewportDefault);

			}
		}


		///<summary>
		///Specifies or returns whether the layer is frozen in new viewports.
		///</summary>
		[NodeInput("AcadLayer", typeof(object))]
		[NodeInput("bDefault", typeof(System.Object))]
		public class Set_ViewportDefault : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ViewportDefault = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the plot style name of a layer.
		///</summary>
		[NodeInput("AcadLayer", typeof(object))]
		public class PlotStyleName : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.PlotStyleName);

			}
		}


		///<summary>
		///Specifies or returns the plot style name of a layer.
		///</summary>
		[NodeInput("AcadLayer", typeof(object))]
		[NodeInput("plotStyle", typeof(System.String))]
		public class Set_PlotStyleName : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.PlotStyleName = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the lineweight of a layer.
		///</summary>
		[NodeInput("AcadLayer", typeof(object))]
		public class Lineweight : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Lineweight);

			}
		}


		///<summary>
		///Specifies or returns the lineweight of a layer.
		///</summary>
		[NodeInput("AcadLayer", typeof(object))]
		[NodeInput("Lineweight", typeof(System.Object))]
		public class Set_Lineweight : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Lineweight = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the description of a layer.
		///</summary>
		[NodeInput("AcadLayer", typeof(object))]
		public class Description : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Description);

			}
		}


		///<summary>
		///Specifies or returns the description of a layer.
		///</summary>
		[NodeInput("AcadLayer", typeof(object))]
		[NodeInput("Description", typeof(System.String))]
		public class Set_Description : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Description = inputs[1];
				return null;
			}
		}


		///<summary>
		///Returns whether the layer is in use.
		///</summary>
		[NodeInput("AcadLayer", typeof(object))]
		public class Used : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Used);

			}
		}


		///<summary>
		///Specifies or returns the material of a layer.
		///</summary>
		[NodeInput("AcadLayer", typeof(object))]
		public class Material : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Material);

			}
		}


		///<summary>
		///Specifies or returns the material of a layer.
		///</summary>
		[NodeInput("AcadLayer", typeof(object))]
		[NodeInput("Material", typeof(System.String))]
		public class Set_Material : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Material = inputs[1];
				return null;
			}
		}
}
