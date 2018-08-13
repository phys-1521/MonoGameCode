﻿/**
 * 
 *  File:       Point.cs
 *  Author:     Allan Anderson
 *  Date:       August 13, 2018
 *  Purpose:    An object that will display as a point on the grid
 *  
 **/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
#endregion

namespace Transform2D
{
    internal class Point
    {
        #region Data Members
        protected Texture2D pointTexture;
        protected static Vector2 pointDimensions = new Vector2(4, 4);
        protected Vector3 pointLocation;
        #endregion

        #region Public Properties
        public static Vector2 PointDimensions
        {
            get { return pointDimensions; }
        }//eop

        public Vector3 PointLocation
        {
            get { return pointLocation; }
            set { pointLocation = value; }
        }//eop
        #endregion

        #region Constructor
        public Point(Vector3 pointLocation)
        {
            PointLocation = pointLocation;
        }//eom
        #endregion

        #region Internal Methods
        internal void LoadContent(ContentManager content)
        {
            pointTexture = content.Load<Texture2D>("point");
        }//eom

        internal void Update(GameTime gameTime)
        {

        }//eom

        internal void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(pointTexture, new Vector2(pointLocation.X, pointLocation.Y * -1), Color.White);
        }//eom
        #endregion

    }//eoc
}//eon
