﻿#region Using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
#endregion

namespace Blazorise
{
    public abstract class BaseTitle : BaseComponent
    {
        #region Members

        private int size = 1;

        #endregion

        #region Methods

        protected override void BuildClasses( ClassBuilder builder )
        {
            builder.Append( ClassProvider.Title() );
            builder.Append( ClassProvider.TitleSize( Size ) );

            base.BuildClasses( builder );
        }

        #endregion

        #region Properties

        [Parameter]
        public int Size
        {
            get => size;
            set
            {
                size = value;

                DirtyClasses();
            }
        }

        [Parameter] public RenderFragment ChildContent { get; set; }

        #endregion
    }
}
