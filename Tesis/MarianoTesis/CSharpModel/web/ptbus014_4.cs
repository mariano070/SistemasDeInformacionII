/*
               File: PTBUS014_4
        Description: Stub for PTBUS014_4
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:29:29.39
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
   public class ptbus014_4 : GXProcedure
   {
      public ptbus014_4( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public ptbus014_4( IGxContext context )
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
                           ref String aP2_TTBUS7_CodResp ,
                           ref short aP3_TTBUS_RubroBien )
      {
         this.AV2NOMBRE_REPORTE = aP0_NOMBRE_REPORTE;
         this.AV3USUARIO = aP1_USUARIO;
         this.AV4TTBUS7_CodResp = aP2_TTBUS7_CodResp;
         this.AV5TTBUS_RubroBien = aP3_TTBUS_RubroBien;
         initialize();
         executePrivate();
         aP0_NOMBRE_REPORTE=this.AV2NOMBRE_REPORTE;
         aP1_USUARIO=this.AV3USUARIO;
         aP2_TTBUS7_CodResp=this.AV4TTBUS7_CodResp;
         aP3_TTBUS_RubroBien=this.AV5TTBUS_RubroBien;
      }

      public short executeUdp( ref String aP0_NOMBRE_REPORTE ,
                               ref String aP1_USUARIO ,
                               ref String aP2_TTBUS7_CodResp )
      {
         this.AV2NOMBRE_REPORTE = aP0_NOMBRE_REPORTE;
         this.AV3USUARIO = aP1_USUARIO;
         this.AV4TTBUS7_CodResp = aP2_TTBUS7_CodResp;
         this.AV5TTBUS_RubroBien = aP3_TTBUS_RubroBien;
         initialize();
         executePrivate();
         aP0_NOMBRE_REPORTE=this.AV2NOMBRE_REPORTE;
         aP1_USUARIO=this.AV3USUARIO;
         aP2_TTBUS7_CodResp=this.AV4TTBUS7_CodResp;
         aP3_TTBUS_RubroBien=this.AV5TTBUS_RubroBien;
         return AV5TTBUS_RubroBien ;
      }

      public void executeSubmit( ref String aP0_NOMBRE_REPORTE ,
                                 ref String aP1_USUARIO ,
                                 ref String aP2_TTBUS7_CodResp ,
                                 ref short aP3_TTBUS_RubroBien )
      {
         ptbus014_4 objptbus014_4;
         objptbus014_4 = new ptbus014_4();
         objptbus014_4.AV2NOMBRE_REPORTE = aP0_NOMBRE_REPORTE;
         objptbus014_4.AV3USUARIO = aP1_USUARIO;
         objptbus014_4.AV4TTBUS7_CodResp = aP2_TTBUS7_CodResp;
         objptbus014_4.AV5TTBUS_RubroBien = aP3_TTBUS_RubroBien;
         objptbus014_4.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbus014_4.executePrivateCatch ));
         aP0_NOMBRE_REPORTE=this.AV2NOMBRE_REPORTE;
         aP1_USUARIO=this.AV3USUARIO;
         aP2_TTBUS7_CodResp=this.AV4TTBUS7_CodResp;
         aP3_TTBUS_RubroBien=this.AV5TTBUS_RubroBien;
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
         args = new Object[] {(String)AV2NOMBRE_REPORTE,(String)AV3USUARIO,(String)AV4TTBUS7_CodResp,(short)AV5TTBUS_RubroBien} ;
         ClassLoader.Execute("aptbus014_4","GeneXus.Programs.aptbus014_4", new Object[] {context }, "execute", args);
         if ( ( args != null ) && ( args.Length == 4 ) )
         {
            AV2NOMBRE_REPORTE = (String)(args[0]) ;
            AV3USUARIO = (String)(args[1]) ;
            AV4TTBUS7_CodResp = (String)(args[2]) ;
            AV5TTBUS_RubroBien = (short)(args[3]) ;
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

      private short AV5TTBUS_RubroBien ;
      private String AV2NOMBRE_REPORTE ;
      private String AV3USUARIO ;
      private String AV4TTBUS7_CodResp ;
      private IGxDataStore dsDefault ;
      private String aP0_NOMBRE_REPORTE ;
      private String aP1_USUARIO ;
      private String aP2_TTBUS7_CodResp ;
      private short aP3_TTBUS_RubroBien ;
      private Object[] args ;
   }

}
