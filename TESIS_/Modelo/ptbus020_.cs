/*
               File: PTBUS020_
        Description: Carga de temporal de cambio de posiciones
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 3/17/2014 13:22:45.43
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
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
   public class ptbus020_ : GXProcedure
   {
      public ptbus020_( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ptbus020_( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref int aP0_TTBUS_Id ,
                           ref String aP1_TTBUS_Descripcion ,
                           ref String aP2_TTBUS20_Mensaje ,
                           ref String aP3_TTBUS20_MotivoEnvio ,
                           ref String aP4_TTBUS20_Observaciones ,
                           ref String aP5_USUARIO ,
                           ref DateTime aP6_TTBUS20_PlazoRecepcion )
      {
         this.AV9TTBUS_Id = aP0_TTBUS_Id;
         this.AV10TTBUS_Descripcion = aP1_TTBUS_Descripcion;
         this.AV11TTBUS20_Mensaje = aP2_TTBUS20_Mensaje;
         this.AV12TTBUS20_MotivoEnvio = aP3_TTBUS20_MotivoEnvio;
         this.AV13TTBUS20_Observaciones = aP4_TTBUS20_Observaciones;
         this.AV8USUARIO = aP5_USUARIO;
         this.AV14TTBUS20_PlazoRecepcion = aP6_TTBUS20_PlazoRecepcion;
         initialize();
         executePrivate();
         aP0_TTBUS_Id=this.AV9TTBUS_Id;
         aP1_TTBUS_Descripcion=this.AV10TTBUS_Descripcion;
         aP2_TTBUS20_Mensaje=this.AV11TTBUS20_Mensaje;
         aP3_TTBUS20_MotivoEnvio=this.AV12TTBUS20_MotivoEnvio;
         aP4_TTBUS20_Observaciones=this.AV13TTBUS20_Observaciones;
         aP5_USUARIO=this.AV8USUARIO;
         aP6_TTBUS20_PlazoRecepcion=this.AV14TTBUS20_PlazoRecepcion;
      }

      public DateTime executeUdp( ref int aP0_TTBUS_Id ,
                                  ref String aP1_TTBUS_Descripcion ,
                                  ref String aP2_TTBUS20_Mensaje ,
                                  ref String aP3_TTBUS20_MotivoEnvio ,
                                  ref String aP4_TTBUS20_Observaciones ,
                                  ref String aP5_USUARIO )
      {
         this.AV9TTBUS_Id = aP0_TTBUS_Id;
         this.AV10TTBUS_Descripcion = aP1_TTBUS_Descripcion;
         this.AV11TTBUS20_Mensaje = aP2_TTBUS20_Mensaje;
         this.AV12TTBUS20_MotivoEnvio = aP3_TTBUS20_MotivoEnvio;
         this.AV13TTBUS20_Observaciones = aP4_TTBUS20_Observaciones;
         this.AV8USUARIO = aP5_USUARIO;
         this.AV14TTBUS20_PlazoRecepcion = aP6_TTBUS20_PlazoRecepcion;
         initialize();
         executePrivate();
         aP0_TTBUS_Id=this.AV9TTBUS_Id;
         aP1_TTBUS_Descripcion=this.AV10TTBUS_Descripcion;
         aP2_TTBUS20_Mensaje=this.AV11TTBUS20_Mensaje;
         aP3_TTBUS20_MotivoEnvio=this.AV12TTBUS20_MotivoEnvio;
         aP4_TTBUS20_Observaciones=this.AV13TTBUS20_Observaciones;
         aP5_USUARIO=this.AV8USUARIO;
         aP6_TTBUS20_PlazoRecepcion=this.AV14TTBUS20_PlazoRecepcion;
         return AV14TTBUS20_PlazoRecepcion ;
      }

      public void executeSubmit( ref int aP0_TTBUS_Id ,
                                 ref String aP1_TTBUS_Descripcion ,
                                 ref String aP2_TTBUS20_Mensaje ,
                                 ref String aP3_TTBUS20_MotivoEnvio ,
                                 ref String aP4_TTBUS20_Observaciones ,
                                 ref String aP5_USUARIO ,
                                 ref DateTime aP6_TTBUS20_PlazoRecepcion )
      {
         ptbus020_ objptbus020_;
         objptbus020_ = new ptbus020_();
         objptbus020_.AV9TTBUS_Id = aP0_TTBUS_Id;
         objptbus020_.AV10TTBUS_Descripcion = aP1_TTBUS_Descripcion;
         objptbus020_.AV11TTBUS20_Mensaje = aP2_TTBUS20_Mensaje;
         objptbus020_.AV12TTBUS20_MotivoEnvio = aP3_TTBUS20_MotivoEnvio;
         objptbus020_.AV13TTBUS20_Observaciones = aP4_TTBUS20_Observaciones;
         objptbus020_.AV8USUARIO = aP5_USUARIO;
         objptbus020_.AV14TTBUS20_PlazoRecepcion = aP6_TTBUS20_PlazoRecepcion;
         objptbus020_.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbus020_.executePrivateCatch ));
         aP0_TTBUS_Id=this.AV9TTBUS_Id;
         aP1_TTBUS_Descripcion=this.AV10TTBUS_Descripcion;
         aP2_TTBUS20_Mensaje=this.AV11TTBUS20_Mensaje;
         aP3_TTBUS20_MotivoEnvio=this.AV12TTBUS20_MotivoEnvio;
         aP4_TTBUS20_Observaciones=this.AV13TTBUS20_Observaciones;
         aP5_USUARIO=this.AV8USUARIO;
         aP6_TTBUS20_PlazoRecepcion=this.AV14TTBUS20_PlazoRecepcion;
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
         /*
            INSERT RECORD ON TABLE TTBUS020

         */
         A223TTBUS20_IdBien = AV9TTBUS_Id ;
         A224TTBUS20_Descripcion = AV10TTBUS_Descripcion ;
         A218TTBUS20_Mensaje = AV11TTBUS20_Mensaje ;
         A219TTBUS20_Estacion = GXUtil.WrkSt( context) ;
         A225TTBUS20_Usuario = AV8USUARIO ;
         A220TTBUS20_MotivoEnvio = AV12TTBUS20_MotivoEnvio ;
         A221TTBUS20_Observaciones = AV13TTBUS20_Observaciones ;
         A222TTBUS20_PlazoRecepcion = AV14TTBUS20_PlazoRecepcion ;
         n222TTBUS20_PlazoRecepcion = false ;
         /* Using cursor P001G2 */
         pr_default.execute(0, new Object[] {A223TTBUS20_IdBien, A224TTBUS20_Descripcion, A218TTBUS20_Mensaje, A220TTBUS20_MotivoEnvio, A221TTBUS20_Observaciones, A219TTBUS20_Estacion, A225TTBUS20_Usuario, n222TTBUS20_PlazoRecepcion, A222TTBUS20_PlazoRecepcion});
         pr_default.close(0);
         if ( (pr_default.getStatus(0) == 1) )
         {
            context.Gx_err = 1 ;
            Gx_emsg = (String)(context.GetMessage( "GXM_noupdate")) ;
         }
         else
         {
            context.Gx_err = 0 ;
            Gx_emsg = "" ;
         }
         /* End Insert */
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("PTBUS020_");
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         A224TTBUS20_Descripcion = "" ;
         A218TTBUS20_Mensaje = "" ;
         A219TTBUS20_Estacion = "" ;
         A225TTBUS20_Usuario = "" ;
         A220TTBUS20_MotivoEnvio = "" ;
         A221TTBUS20_Observaciones = "" ;
         A222TTBUS20_PlazoRecepcion = DateTime.MinValue ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ptbus020___default(),
            new Object[][] {
                new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private int AV9TTBUS_Id ;
      private int GX_INS13 ;
      private int A223TTBUS20_IdBien ;
      private String AV8USUARIO ;
      private String A224TTBUS20_Descripcion ;
      private String A219TTBUS20_Estacion ;
      private String A225TTBUS20_Usuario ;
      private String Gx_emsg ;
      private DateTime AV14TTBUS20_PlazoRecepcion ;
      private DateTime A222TTBUS20_PlazoRecepcion ;
      private bool n222TTBUS20_PlazoRecepcion ;
      private String AV10TTBUS_Descripcion ;
      private String AV11TTBUS20_Mensaje ;
      private String AV12TTBUS20_MotivoEnvio ;
      private String AV13TTBUS20_Observaciones ;
      private String A218TTBUS20_Mensaje ;
      private String A220TTBUS20_MotivoEnvio ;
      private String A221TTBUS20_Observaciones ;
      private IGxDataStore dsDefault ;
      private int aP0_TTBUS_Id ;
      private String aP1_TTBUS_Descripcion ;
      private String aP2_TTBUS20_Mensaje ;
      private String aP3_TTBUS20_MotivoEnvio ;
      private String aP4_TTBUS20_Observaciones ;
      private String aP5_USUARIO ;
      private DateTime aP6_TTBUS20_PlazoRecepcion ;
      private IDataStoreProvider pr_default ;
   }

   public class ptbus020___default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new UpdateCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP001G2 ;
          prmP001G2 = new Object[] {
          new Object[] {"@TTBUS20_IdBien",SqlDbType.Int,8,0} ,
          new Object[] {"@TTBUS20_Descripcion",SqlDbType.Char,50,0} ,
          new Object[] {"@TTBUS20_Mensaje",SqlDbType.VarChar,100,0} ,
          new Object[] {"@TTBUS20_MotivoEnvio",SqlDbType.VarChar,100,0} ,
          new Object[] {"@TTBUS20_Observaciones",SqlDbType.VarChar,500,0} ,
          new Object[] {"@TTBUS20_Estacion",SqlDbType.Char,20,0} ,
          new Object[] {"@TTBUS20_Usuario",SqlDbType.Char,16,0} ,
          new Object[] {"@TTBUS20_PlazoRecepcion",SqlDbType.DateTime,8,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001G2", "INSERT INTO [TTBUS020] ([TTBUS20_IdBien], [TTBUS20_Descripcion], [TTBUS20_Mensaje], [TTBUS20_MotivoEnvio], [TTBUS20_Observaciones], [TTBUS20_Estacion], [TTBUS20_Usuario], [TTBUS20_PlazoRecepcion]) VALUES (@TTBUS20_IdBien, @TTBUS20_Descripcion, @TTBUS20_Mensaje, @TTBUS20_MotivoEnvio, @TTBUS20_Observaciones, @TTBUS20_Estacion, @TTBUS20_Usuario, @TTBUS20_PlazoRecepcion)", GxErrorMask.GX_NOMASK,prmP001G2)
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                if ( (bool)parms[7] )
                {
                   stmt.setNull( 8 , SqlDbType.DateTime );
                }
                else
                {
                   stmt.SetParameter(8, (DateTime)parms[8]);
                }
                break;
       }
    }

 }

}
