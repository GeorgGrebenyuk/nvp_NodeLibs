using NVP.API.Nodes;

namespace OdaX.AcadSummaryInfo 
{
		[NodeInput("dynamic", typeof(object))]
		public class AcadSummaryInfo_Constructor : INode 
		{
		public OdaX.IAcadSummaryInfo _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0 as OdaX.IAcadSummaryInfo;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}
		[NodeInput("dynamic", typeof(object))]
		public class AcadSummaryInfo_ConstructorCast : INode 
		{
		public OdaX.IAcadSummaryInfo _i;
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				this._i = _input0._i as OdaX.IAcadSummaryInfo;
				if (this._i == null) throw new Exception("Invalid casting");
				return new NodeResult(this);
			}
		}


		///<summary>
		///Specifies or returns the author value of the summary information.
		///</summary>
		[NodeInput("AcadSummaryInfo", typeof(object))]
		public class Author : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Author);

			}
		}


		///<summary>
		///Specifies or returns the author value of the summary information.
		///</summary>
		[NodeInput("AcadSummaryInfo", typeof(object))]
		[NodeInput("pAuthor", typeof(System.String))]
		public class Set_Author : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Author = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the comments value of the summary information.
		///</summary>
		[NodeInput("AcadSummaryInfo", typeof(object))]
		public class Comments : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Comments);

			}
		}


		///<summary>
		///Specifies or returns the comments value of the summary information.
		///</summary>
		[NodeInput("AcadSummaryInfo", typeof(object))]
		[NodeInput("pComments", typeof(System.String))]
		public class Set_Comments : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Comments = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the hyperlink base value of the summary information.
		///</summary>
		[NodeInput("AcadSummaryInfo", typeof(object))]
		public class HyperlinkBase : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.HyperlinkBase);

			}
		}


		///<summary>
		///Specifies or returns the hyperlink base value of the summary information.
		///</summary>
		[NodeInput("AcadSummaryInfo", typeof(object))]
		[NodeInput("pHyperlinkBase", typeof(System.String))]
		public class Set_HyperlinkBase : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.HyperlinkBase = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the keywords value of the summary information.
		///</summary>
		[NodeInput("AcadSummaryInfo", typeof(object))]
		public class Keywords : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Keywords);

			}
		}


		///<summary>
		///Specifies or returns the keywords value of the summary information.
		///</summary>
		[NodeInput("AcadSummaryInfo", typeof(object))]
		[NodeInput("pKeywords", typeof(System.String))]
		public class Set_Keywords : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Keywords = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the login name of the user who last saved the drawing.
		///</summary>
		[NodeInput("AcadSummaryInfo", typeof(object))]
		public class LastSavedBy : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.LastSavedBy);

			}
		}


		///<summary>
		///Specifies or returns the login name of the user who last saved the drawing.
		///</summary>
		[NodeInput("AcadSummaryInfo", typeof(object))]
		[NodeInput("pLastSavedBy", typeof(System.String))]
		public class Set_LastSavedBy : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.LastSavedBy = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the revision number value of the summary information.
		///</summary>
		[NodeInput("AcadSummaryInfo", typeof(object))]
		public class RevisionNumber : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.RevisionNumber);

			}
		}


		///<summary>
		///Specifies or returns the revision number value of the summary information.
		///</summary>
		[NodeInput("AcadSummaryInfo", typeof(object))]
		[NodeInput("pRevisionNumber", typeof(System.String))]
		public class Set_RevisionNumber : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.RevisionNumber = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the subject value of the summary information.
		///</summary>
		[NodeInput("AcadSummaryInfo", typeof(object))]
		public class Subject : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Subject);

			}
		}


		///<summary>
		///Specifies or returns the subject value of the summary information.
		///</summary>
		[NodeInput("AcadSummaryInfo", typeof(object))]
		[NodeInput("pSubject", typeof(System.String))]
		public class Set_Subject : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Subject = inputs[1];
				return null;
			}
		}


		///<summary>
		///Specifies or returns the title value of the summary information.
		///</summary>
		[NodeInput("AcadSummaryInfo", typeof(object))]
		public class Title : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.Title);

			}
		}


		///<summary>
		///Specifies or returns the title value of the summary information.
		///</summary>
		[NodeInput("AcadSummaryInfo", typeof(object))]
		[NodeInput("pTitle", typeof(System.String))]
		public class Set_Title : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.Title = inputs[1];
				return null;
			}
		}


		///<summary>
		///Returns the number of custom information items that have been defined for the summary information.
		///</summary>
		[NodeInput("AcadSummaryInfo", typeof(object))]
		public class NumCustomInfo : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				return new NodeResult(_input0._i.NumCustomInfo);

			}
		}


		///<summary>
		///Using an index, returns the key and value of custom information that is defined for the summary information.
		///</summary>
		[NodeInput("AcadSummaryInfo", typeof(object))]
		[NodeInput("Index", typeof(System.Int32))]
		[NodeInput("pKey", typeof(System.String))]
		[NodeInput("pValue", typeof(System.String))]
		public class GetCustomByIndex : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.GetCustomByIndex(inputs[1],inputs[2],inputs[3]);
				return null;
			}
		}


		///<summary>
		///Using a key, returns the key and value of custom information that is defined for the summary information.
		///</summary>
		[NodeInput("AcadSummaryInfo", typeof(object))]
		[NodeInput("key", typeof(System.String))]
		[NodeInput("pValue", typeof(System.String))]
		public class GetCustomByKey : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.GetCustomByKey(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///Using an index, specifies the key and value of custom information defined for the summary information.
		///</summary>
		[NodeInput("AcadSummaryInfo", typeof(object))]
		[NodeInput("Index", typeof(System.Int32))]
		[NodeInput("key", typeof(System.String))]
		[NodeInput("Value", typeof(System.String))]
		public class SetCustomByIndex : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetCustomByIndex(inputs[1],inputs[2],inputs[3]);
				return null;
			}
		}


		///<summary>
		///Using a key, specifies the key and value of custom information defined for the summary information.
		///</summary>
		[NodeInput("AcadSummaryInfo", typeof(object))]
		[NodeInput("key", typeof(System.String))]
		[NodeInput("Value", typeof(System.String))]
		public class SetCustomByKey : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.SetCustomByKey(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///name) and value to the summary information.
		///</summary>
		[NodeInput("AcadSummaryInfo", typeof(object))]
		[NodeInput("key", typeof(System.String))]
		[NodeInput("Value", typeof(System.String))]
		public class AddCustomInfo : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.AddCustomInfo(inputs[1],inputs[2]);
				return null;
			}
		}


		///<summary>
		///Removes custom information using its index.
		///</summary>
		[NodeInput("AcadSummaryInfo", typeof(object))]
		[NodeInput("Index", typeof(System.Int32))]
		public class RemoveCustomByIndex : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.RemoveCustomByIndex(inputs[1]);
				return null;
			}
		}


		///<summary>
		///Removes custom information using its key.
		///</summary>
		[NodeInput("AcadSummaryInfo", typeof(object))]
		[NodeInput("key", typeof(System.String))]
		public class RemoveCustomByKey : INode
		{
			public NodeResult Execute(INVPData context, List<NodeResult> inputs)
			{
				dynamic _input0 = inputs[0].Value;
				_input0._i.RemoveCustomByKey(inputs[1]);
				return null;
			}
		}
}
