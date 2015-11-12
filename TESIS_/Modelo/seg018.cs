/*
               File: SEG018
        Description: Stub for SEG018
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:19:24.17
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using System.Web.Services.Protocols;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class seg018 : GXProcedure
   {
      public seg018( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public seg018( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_TIPO )
      {
         this.AV2TIPO = aP0_TIPO;
         initialize();
         executePrivate();
         aP0_TIPO=this.AV2TIPO;
      }

      public String executeUdp( )
      {
         this.AV2TIPO = aP0_TIPO;
         initialize();
         executePrivate();
         aP0_TIPO=this.AV2TIPO;
         return AV2TIPO ;
      }

      public void executeSubmit( ref String aP0_TIPO )
      {
         seg018 objseg018;
         objseg018 = new seg018();
         objseg018.AV2TIPO = aP0_TIPO;
         objseg018.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objseg018.executePrivateCatch ));
         aP0_TIPO=this.AV2TIPO;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         args = new Object[] {(String)AV2TIPO} ;
         ClassLoader.Execute("aseg018","GeneXus.Programs.aseg018", new Object[] {context }, "execute", args);
         if ( ( args != null ) && ( args.Length == 1 ) )
         {
            AV2TIPO = (String)(args[0]) ;
         }
         this.cleanup();
      }

      protected void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private String AV2TIPO ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private String aP0_TIPO ;
      private Object[] args ;
   }

}
