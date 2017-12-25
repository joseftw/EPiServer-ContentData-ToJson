﻿using System;
using System.Reflection;
using EPiServer.Core;

namespace JOS.ContentSerializer.Internal
{
    public class BlockDataPropertyHandler : IPropertyHandler<BlockData>
    {
        private readonly IPropertyManager _propertyManager;

        public BlockDataPropertyHandler(IPropertyManager propertyManager)
        {
            _propertyManager = propertyManager ?? throw new ArgumentNullException(nameof(propertyManager));
        }

        public object Handle(BlockData value, PropertyInfo property, IContentData contentData)
        {
            return this._propertyManager.GetStructuredData(value, new ContentSerializerSettings()); // TODO allow injection of settings.
        }
    }
}