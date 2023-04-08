﻿using Crimson.CSharp.Exceptions;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Crimson.CSharp.Core.CURI
{
    /// <summary>
    /// <para>
    ///     <b>Crimson URI</b>
    /// </para>
    /// <para>
    ///     A wrapper class for a Uri which conceals all of the strange things which Crimson 
    ///     does in the background (i.e. custom "root.crimson" and "native.crimson" hosts).
    /// </para>
    /// </summary>
    public class NativeCURI : AbstractCURI
    {

        public static readonly string SCHEME = "native";

        public string AbsolutePath
        {
            get
            {
                string native = WebUtility.UrlDecode(Crimson.Options.NativeCURI.Uri.AbsolutePath);

                string abs = WebUtility.UrlDecode(Uri.AbsolutePath);

                string path = Path.Combine(native, abs);
                return path;
            }
        }

        public NativeCURI (Uri uri) : base(uri)
        {
            if (!SCHEME.Equals(uri.Scheme)) throw new UriFormatException($"{GetType()} may only take URIs of scheme {SCHEME}.");
            if (Path.IsPathRooted(AbsolutePath)) throw new UriFormatException($"The path of a URI with host {SCHEME} may not be rooted.");
        }

        public override bool Equals (AbstractCURI? other)
        {
            return other?.Uri?.Equals(Uri) ?? false;
        }

        public override async Task<Stream> GetStream ()
        {
            return await Task.Run(() => File.OpenRead(AbsolutePath));
        }

        public class Factory : ICURIFactory
        {
            public AbstractCURI Make (Uri uri)
            {
                return new NativeCURI(uri);
            }
        }
    }
}
