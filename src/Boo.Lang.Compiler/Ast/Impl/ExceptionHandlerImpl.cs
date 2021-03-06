#region license
// Copyright (c) 2009 Rodrigo B. de Oliveira (rbo@acm.org)
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without modification,
// are permitted provided that the following conditions are met:
// 
//     * Redistributions of source code must retain the above copyright notice,
//     this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above copyright notice,
//     this list of conditions and the following disclaimer in the documentation
//     and/or other materials provided with the distribution.
//     * Neither the name of Rodrigo B. de Oliveira nor the names of its
//     contributors may be used to endorse or promote products derived from this
//     software without specific prior written permission.
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
// WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE
// FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
// DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
// SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
// CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
// OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF
// THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
#endregion

//
// DO NOT EDIT THIS FILE!
//
// This file was generated automatically by astgen.boo.
//
namespace Boo.Lang.Compiler.Ast
{	
	using System.Collections;
	using System.Runtime.Serialization;
	
	[System.Serializable]
	public partial class ExceptionHandler : Node
	{
		protected Declaration _declaration;

		protected Expression _filterCondition;

		protected ExceptionHandlerFlags _flags;

		protected Block _block;


		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		new public ExceptionHandler CloneNode()
		{
			return (ExceptionHandler)Clone();
		}
		
		/// <summary>
		/// <see cref="Node.CleanClone"/>
		/// </summary>
		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		new public ExceptionHandler CleanClone()
		{
			return (ExceptionHandler)base.CleanClone();
		}

		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		override public NodeType NodeType
		{
			get { return NodeType.ExceptionHandler; }
		}

		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		override public void Accept(IAstVisitor visitor)
		{
			visitor.OnExceptionHandler(this);
		}

		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		override public bool Matches(Node node)
		{	
			if (node == null) return false;
			if (NodeType != node.NodeType) return false;
			var other = ( ExceptionHandler)node;
			if (!Node.Matches(_declaration, other._declaration)) return NoMatch("ExceptionHandler._declaration");
			if (!Node.Matches(_filterCondition, other._filterCondition)) return NoMatch("ExceptionHandler._filterCondition");
			if (_flags != other._flags) return NoMatch("ExceptionHandler._flags");
			if (!Node.Matches(_block, other._block)) return NoMatch("ExceptionHandler._block");
			return true;
		}

		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		override public bool Replace(Node existing, Node newNode)
		{
			if (base.Replace(existing, newNode))
			{
				return true;
			}
			if (_declaration == existing)
			{
				this.Declaration = (Declaration)newNode;
				return true;
			}
			if (_filterCondition == existing)
			{
				this.FilterCondition = (Expression)newNode;
				return true;
			}
			if (_block == existing)
			{
				this.Block = (Block)newNode;
				return true;
			}
			return false;
		}

		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		override public object Clone()
		{
			ExceptionHandler clone = (ExceptionHandler)FormatterServices.GetUninitializedObject(typeof(ExceptionHandler));
			clone._lexicalInfo = _lexicalInfo;
			clone._endSourceLocation = _endSourceLocation;
			clone._documentation = _documentation;
			clone._isSynthetic = _isSynthetic;
			clone._entity = _entity;
			if (_annotations != null) clone._annotations = (Hashtable)_annotations.Clone();
		
			if (null != _declaration)
			{
				clone._declaration = _declaration.Clone() as Declaration;
				clone._declaration.InitializeParent(clone);
			}
			if (null != _filterCondition)
			{
				clone._filterCondition = _filterCondition.Clone() as Expression;
				clone._filterCondition.InitializeParent(clone);
			}
			clone._flags = _flags;
			if (null != _block)
			{
				clone._block = _block.Clone() as Block;
				clone._block.InitializeParent(clone);
			}
			return clone;
		}

		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		override internal void ClearTypeSystemBindings()
		{
			_annotations = null;
			_entity = null;
			if (null != _declaration)
			{
				_declaration.ClearTypeSystemBindings();
			}
			if (null != _filterCondition)
			{
				_filterCondition.ClearTypeSystemBindings();
			}
			if (null != _block)
			{
				_block.ClearTypeSystemBindings();
			}

		}
	

		[System.Xml.Serialization.XmlElement]
		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		public Declaration Declaration
		{
			
			get { return _declaration; }
			set
			{
				if (_declaration != value)
				{
					_declaration = value;
					if (null != _declaration)
					{
						_declaration.InitializeParent(this);
					}
				}
			}

		}
		

		[System.Xml.Serialization.XmlElement]
		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		public Expression FilterCondition
		{
			
			get { return _filterCondition; }
			set
			{
				if (_filterCondition != value)
				{
					_filterCondition = value;
					if (null != _filterCondition)
					{
						_filterCondition.InitializeParent(this);
					}
				}
			}

		}
		

		[System.Xml.Serialization.XmlElement]
		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		public ExceptionHandlerFlags Flags
		{
			
			get { return _flags; }
			set { _flags = value; }

		}
		

		[System.Xml.Serialization.XmlElement]
		[System.CodeDom.Compiler.GeneratedCodeAttribute("astgen.boo", "1")]
		public Block Block
		{
			
			get
			{ 
				if (_block == null)
				{
					_block = new Block();
					_block.InitializeParent(this);
				}
				return _block;
			}
			set
			{
				if (_block != value)
				{
					_block = value;
					if (null != _block)
					{
						_block.InitializeParent(this);
					}
				}
			}

		}
		

	}
}

