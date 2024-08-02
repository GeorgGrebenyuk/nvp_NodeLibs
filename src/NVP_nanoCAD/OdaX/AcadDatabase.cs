using NVP.API.Nodes;

namespace OdaX.AcadDatabase 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadDatabase_Constructor : INode 
		{
		public OdaX.IAcadDatabase _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadDatabase;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadDatabase_ConstructorCast : INode 
		{
		public OdaX.IAcadDatabase _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadDatabase;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Returns the ModelSpace collection for a document.
		///</summary>
		[NodeInput("AcadDatabase", typeof(object))]
		public class ModelSpace : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ModelSpace);

			}
		}


		///<summary>
		///Returns the PaperSpace collection for a document.
		///</summary>
		[NodeInput("AcadDatabase", typeof(object))]
		public class PaperSpace : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.PaperSpace);

			}
		}


		///<summary>
		///Returns the Blocks collection for a document.
		///</summary>
		[NodeInput("AcadDatabase", typeof(object))]
		public class Blocks : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Blocks);

			}
		}


		///<summary>
		///Duplicates multiple objects.
		///</summary>
		[NodeInput("AcadDatabase", typeof(object))]
		[NodeInput("Objects", typeof(System.Object))]
		[NodeInput("Owner", typeof(System.Object))]
		[NodeInput("IdPairs", typeof(System.Object))]
		public class CopyObjects : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.CopyObjects(inputs[1],inputs[2],inputs[3]));

			}
		}


		///<summary>
		///Returns the Groups Collection object for a document.
		///</summary>
		[NodeInput("AcadDatabase", typeof(object))]
		public class Groups : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Groups);

			}
		}


		///<summary>
		///Returns the DimStyles Collection object for a document.
		///</summary>
		[NodeInput("AcadDatabase", typeof(object))]
		public class DimStyles : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.DimStyles);

			}
		}


		///<summary>
		///Returns the Layers Collection object for a document.
		///</summary>
		[NodeInput("AcadDatabase", typeof(object))]
		public class Layers : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Layers);

			}
		}


		///<summary>
		///Returns the Linetypes Collection object for a document.
		///</summary>
		[NodeInput("AcadDatabase", typeof(object))]
		public class Linetypes : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Linetypes);

			}
		}


		///<summary>
		///Returns the Dictionaries Collection object for a document.
		///</summary>
		[NodeInput("AcadDatabase", typeof(object))]
		public class Dictionaries : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Dictionaries);

			}
		}


		///<summary>
		///Returns the RegisteredApplications Collection object for a document.
		///</summary>
		[NodeInput("AcadDatabase", typeof(object))]
		public class RegisteredApplications : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.RegisteredApplications);

			}
		}


		///<summary>
		///Returns the TextStyles Collection object of a document.
		///</summary>
		[NodeInput("AcadDatabase", typeof(object))]
		public class TextStyles : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.TextStyles);

			}
		}


		///<summary>
		///Returns the UCSs Collection object of a document.
		///</summary>
		[NodeInput("AcadDatabase", typeof(object))]
		public class UserCoordinateSystems : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.UserCoordinateSystems);

			}
		}


		///<summary>
		///Returns the Views Collection object of a document.
		///</summary>
		[NodeInput("AcadDatabase", typeof(object))]
		public class Views : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Views);

			}
		}


		///<summary>
		///Returns the Viewports Collection object of a document.
		///</summary>
		[NodeInput("AcadDatabase", typeof(object))]
		public class Viewports : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Viewports);

			}
		}


		///<summary>
		///Specifies or returns the elevation in modelspace.
		///</summary>
		[NodeInput("AcadDatabase", typeof(object))]
		public class ElevationModelSpace : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ElevationModelSpace);

			}
		}


		///<summary>
		///Specifies or returns the elevation in modelspace.
		///</summary>
		[NodeInput("AcadDatabase", typeof(object))]
		[NodeInput("Elevation", typeof(System.Double))]
		public class Set_ElevationModelSpace : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ElevationModelSpace = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the elevation in paperspace.
		///</summary>
		[NodeInput("AcadDatabase", typeof(object))]
		public class ElevationPaperSpace : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ElevationPaperSpace);

			}
		}


		///<summary>
		///Specifies or returns the elevation in paperspace.
		///</summary>
		[NodeInput("AcadDatabase", typeof(object))]
		[NodeInput("Elevation", typeof(System.Double))]
		public class Set_ElevationPaperSpace : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.ElevationPaperSpace = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the drawing limits of a document.
		///</summary>
		[NodeInput("AcadDatabase", typeof(object))]
		public class Limits : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Limits);

			}
		}


		///<summary>
		///Specifies or returns the drawing limits of a document.
		///</summary>
		[NodeInput("AcadDatabase", typeof(object))]
		[NodeInput("Limits", typeof(System.Object))]
		public class Set_Limits : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Limits = inputs[1];
				return null;
			}
		}


		///<summary>
		///Returns the object that corresponds with a specified handle.
		///</summary>
		[NodeInput("AcadDatabase", typeof(object))]
		[NodeInput("Handle", typeof(System.String))]
		public class HandleToObject : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.HandleToObject(inputs[1]));

			}
		}


		///<summary>
		///Returns the object that corresponds with a specified object ID.
		///</summary>
		[NodeInput("AcadDatabase", typeof(object))]
		[NodeInput("ObjectID", typeof(System.Object))]
		public class ObjectIdToObject : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.ObjectIdToObject(inputs[1]));

			}
		}


		///<summary>
		///Returns the Layouts Collection object for a document.
		///</summary>
		[NodeInput("AcadDatabase", typeof(object))]
		public class Layouts : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Layouts);

			}
		}


		///<summary>
		///Returns the PlotConfigurations Collection object for a document.
		///</summary>
		[NodeInput("AcadDatabase", typeof(object))]
		public class PlotConfigurations : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.PlotConfigurations);

			}
		}


		///<summary>
		///Returns the Preferences object for a document.
		///</summary>
		[NodeInput("AcadDatabase", typeof(object))]
		public class Preferences : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Preferences);

			}
		}


		///<summary>
		///Returns the FileDependencies Collection object for a document.
		///</summary>
		[NodeInput("AcadDatabase", typeof(object))]
		public class FileDependencies : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.FileDependencies);

			}
		}


		///<summary>
		///Returns the SummaryInfo object for a document.
		///</summary>
		[NodeInput("AcadDatabase", typeof(object))]
		public class SummaryInfo : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.SummaryInfo);

			}
		}


		///<summary>
		///Returns the SectionManager Collection object for a document.
		///</summary>
		[NodeInput("AcadDatabase", typeof(object))]
		public class SectionManager : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.SectionManager);

			}
		}


		///<summary>
		///Returns the Materials Collection object for a document.
		///</summary>
		[NodeInput("AcadDatabase", typeof(object))]
		public class Materials : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Materials);

			}
		}
}
