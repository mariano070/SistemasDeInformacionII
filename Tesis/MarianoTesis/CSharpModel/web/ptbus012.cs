/*
               File: PTBUS012
        Description: Stub for PTBUS012
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:28:57.43
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
   public class ptbus012 : GXProcedure
   {
      public ptbus012( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public ptbus012( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_NOMBRE_REPORTE ,
                           ref String aP1_USUARIO ,
                           ref int aP2_TTBUS_Id )
      {
         this.AV2NOMBRE_REPORTE = aP0_NOMBRE_REPORTE;
         this.AV3USUARIO = aP1_USUARIO;
         this.AV4TTBUS_Id = aP2_TTBUS_Id;
         initialize();
         executePrivate();
         aP0_NOMBRE_REPORTE=this.AV2NOMBRE_REPORTE;
         aP1_USUARIO=this.AV3USUARIO;
         aP2_TTBUS_Id=this.AV4TTBUS_Id;
      }

      public int executeUdp( ref String aP0_NOMBRE_REPORTE ,
                             ref String aP1_USUARIO )
      {
         this.AV2NOMBRE_REPORTE = aP0_NOMBRE_REPORTE;
         this.AV3USUARIO = aP1_USUARIO;
         this.AV4TTBUS_Id = aP2_TTBUS_Id;
         initialize();
         executePrivate();
         aP0_NOMBRE_REPORTE=this.AV2NOMBRE_REPORTE;
         aP1_USUARIO=this.AV3USUARIO;
         aP2_TTBUS_Id=this.AV4TTBUS_Id;
         return AV4TTBUS_Id ;
      }

      public void executeSubmit( ref String aP0_NOMBRE_REPORTE ,
                                 ref String aP1_USUARIO ,
                                 ref int aP2_TTBUS_Id )
      {
         ptbus012 objptbus012;
         objptbus012 = new ptbus012();
         objptbus012.AV2NOMBRE_REPORTE = aP0_NOMBRE_REPORTE;
         objptbus012.AV3USUARIO = aP1_USUARIO;
         objptbus012.AV4TTBUS_Id = aP2_TTBUS_Id;
         objptbus012.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbus012.executePrivateCatch ));
         aP0_NOMBRE_REPORTE=this.AV2NOMBRE_REPORTE;
         aP1_USUARIO=this.AV3USUARIO;
         aP2_TTBUS_Id=this.AV4TTBUS_Id;
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
         args = new Object[] {(String)AV2NOMBRE_REPORTE,(String)AV3USUARIO,(int)AV4TTBUS_Id} ;
         ClassLoader.Execute("aptbus012","GeneXus.Programs.aptbus012", new Object[] {context }, "execute", args);
         if ( ( args != null ) && ( args.Length == 3 ) )
         {
            AV2NOMBRE_REPORTE = (String)(args[0]) ;
            AV3USUARIO = (String)(args[1]) ;
            AV4TTBUS_Id = (int)(args[2]) ;
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

      private int AV4TTBUS_Id ;
      private String AV2NOMBRE_REPORTE ;
      private String AV3USUARIO ;
      private IGxDataStore dsDefault ;
      private String aP0_NOMBRE_REPORTE ;
      private String aP1_USUARIO ;
      private int aP2_TTBUS_Id ;
      private Object[] args ;
   }

}
