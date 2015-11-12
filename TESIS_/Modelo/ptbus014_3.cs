/*
               File: PTBUS014_3
        Description: Stub for PTBUS014_3
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 2/26/2014 11:46:40.39
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
   public class ptbus014_3 : GXProcedure
   {
      public ptbus014_3( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public ptbus014_3( IGxContext context )
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
                           ref short aP2_TTBUS7_Pos ,
                           ref String aP3_TTBUS7_CodResp ,
                           ref short aP4_TTBUS_RubroBien )
      {
         this.AV2NOMBRE_REPORTE = aP0_NOMBRE_REPORTE;
         this.AV3USUARIO = aP1_USUARIO;
         this.AV4TTBUS7_Pos = aP2_TTBUS7_Pos;
         this.AV5TTBUS7_CodResp = aP3_TTBUS7_CodResp;
         this.AV6TTBUS_RubroBien = aP4_TTBUS_RubroBien;
         initialize();
         executePrivate();
         aP0_NOMBRE_REPORTE=this.AV2NOMBRE_REPORTE;
         aP1_USUARIO=this.AV3USUARIO;
         aP2_TTBUS7_Pos=this.AV4TTBUS7_Pos;
         aP3_TTBUS7_CodResp=this.AV5TTBUS7_CodResp;
         aP4_TTBUS_RubroBien=this.AV6TTBUS_RubroBien;
      }

      public short executeUdp( ref String aP0_NOMBRE_REPORTE ,
                               ref String aP1_USUARIO ,
                               ref short aP2_TTBUS7_Pos ,
                               ref String aP3_TTBUS7_CodResp )
      {
         this.AV2NOMBRE_REPORTE = aP0_NOMBRE_REPORTE;
         this.AV3USUARIO = aP1_USUARIO;
         this.AV4TTBUS7_Pos = aP2_TTBUS7_Pos;
         this.AV5TTBUS7_CodResp = aP3_TTBUS7_CodResp;
         this.AV6TTBUS_RubroBien = aP4_TTBUS_RubroBien;
         initialize();
         executePrivate();
         aP0_NOMBRE_REPORTE=this.AV2NOMBRE_REPORTE;
         aP1_USUARIO=this.AV3USUARIO;
         aP2_TTBUS7_Pos=this.AV4TTBUS7_Pos;
         aP3_TTBUS7_CodResp=this.AV5TTBUS7_CodResp;
         aP4_TTBUS_RubroBien=this.AV6TTBUS_RubroBien;
         return AV6TTBUS_RubroBien ;
      }

      public void executeSubmit( ref String aP0_NOMBRE_REPORTE ,
                                 ref String aP1_USUARIO ,
                                 ref short aP2_TTBUS7_Pos ,
                                 ref String aP3_TTBUS7_CodResp ,
                                 ref short aP4_TTBUS_RubroBien )
      {
         ptbus014_3 objptbus014_3;
         objptbus014_3 = new ptbus014_3();
         objptbus014_3.AV2NOMBRE_REPORTE = aP0_NOMBRE_REPORTE;
         objptbus014_3.AV3USUARIO = aP1_USUARIO;
         objptbus014_3.AV4TTBUS7_Pos = aP2_TTBUS7_Pos;
         objptbus014_3.AV5TTBUS7_CodResp = aP3_TTBUS7_CodResp;
         objptbus014_3.AV6TTBUS_RubroBien = aP4_TTBUS_RubroBien;
         objptbus014_3.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbus014_3.executePrivateCatch ));
         aP0_NOMBRE_REPORTE=this.AV2NOMBRE_REPORTE;
         aP1_USUARIO=this.AV3USUARIO;
         aP2_TTBUS7_Pos=this.AV4TTBUS7_Pos;
         aP3_TTBUS7_CodResp=this.AV5TTBUS7_CodResp;
         aP4_TTBUS_RubroBien=this.AV6TTBUS_RubroBien;
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
         args = new Object[] {(String)AV2NOMBRE_REPORTE,(String)AV3USUARIO,(short)AV4TTBUS7_Pos,(String)AV5TTBUS7_CodResp,(short)AV6TTBUS_RubroBien} ;
         ClassLoader.Execute("aptbus014_3","GeneXus.Programs.aptbus014_3", new Object[] {context }, "execute", args);
         if ( ( args != null ) && ( args.Length == 5 ) )
         {
            AV2NOMBRE_REPORTE = (String)(args[0]) ;
            AV3USUARIO = (String)(args[1]) ;
            AV4TTBUS7_Pos = (short)(args[2]) ;
            AV5TTBUS7_CodResp = (String)(args[3]) ;
            AV6TTBUS_RubroBien = (short)(args[4]) ;
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

      private short AV4TTBUS7_Pos ;
      private short AV6TTBUS_RubroBien ;
      private String AV2NOMBRE_REPORTE ;
      private String AV3USUARIO ;
      private String AV5TTBUS7_CodResp ;
      private IGxDataStore dsDefault ;
      private String aP0_NOMBRE_REPORTE ;
      private String aP1_USUARIO ;
      private short aP2_TTBUS7_Pos ;
      private String aP3_TTBUS7_CodResp ;
      private short aP4_TTBUS_RubroBien ;
      private Object[] args ;
   }

}
