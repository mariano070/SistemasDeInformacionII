/*
               File: IsAuthorizedX
        Description: Autorización Master Page IntranetX
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:17:33.82
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
   public class isauthorizedx : GXProcedure
   {
      public isauthorizedx( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public isauthorizedx( IGxContext context )
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

      public void execute( short aP0_SIS_COD ,
                           String aP1_GxObject ,
                           out bool aP2_Authorized )
      {
         this.AV13SIS_COD = aP0_SIS_COD;
         this.GxObject = aP1_GxObject;
         this.AV9Authorized = false ;
         initialize();
         executePrivate();
         aP2_Authorized=this.AV9Authorized;
      }

      public bool executeUdp( short aP0_SIS_COD ,
                              String aP1_GxObject )
      {
         this.AV13SIS_COD = aP0_SIS_COD;
         this.GxObject = aP1_GxObject;
         this.AV9Authorized = false ;
         initialize();
         executePrivate();
         aP2_Authorized=this.AV9Authorized;
         return AV9Authorized ;
      }

      public void executeSubmit( short aP0_SIS_COD ,
                                 String aP1_GxObject ,
                                 out bool aP2_Authorized )
      {
         isauthorizedx objisauthorizedx;
         objisauthorizedx = new isauthorizedx();
         objisauthorizedx.AV13SIS_COD = aP0_SIS_COD;
         objisauthorizedx.GxObject = aP1_GxObject;
         objisauthorizedx.AV9Authorized = false ;
         objisauthorizedx.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objisauthorizedx.executePrivateCatch ));
         aP2_Authorized=this.AV9Authorized;
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
         AV9Authorized = false ;
         new loadcontext(context ).execute( out  AV11Context) ;
         AV14USUARIO = StringUtil.Upper( AV11Context.gxTpr_User) ;
         AV12PRG_COD = AV11Context.gxTpr_Programa ;
         /* Using cursor P000Q2 */
         pr_default.execute(0, new Object[] {AV14USUARIO, AV13SIS_COD});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A116SIS_COD = P000Q2_A116SIS_COD[0] ;
            A6USU_COD = P000Q2_A6USU_COD[0] ;
            AV9Authorized = true ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         /*
            INSERT RECORD ON TABLE SEG009

         */
         A116SIS_COD = AV13SIS_COD ;
         A126PRG_COD = AV12PRG_COD ;
         A152ACW_OBJ = GxObject ;
         A153ACW_OBS = AV14USUARIO + " ALTA AUTOMATICA" ;
         A154ACW_MOM = DateTimeUtil.Now( ) ;
         /* Using cursor P000Q3 */
         pr_default.execute(1, new Object[] {A116SIS_COD, A126PRG_COD, A152ACW_OBJ, A153ACW_OBS, A154ACW_MOM});
         pr_default.close(1);
         if ( (pr_default.getStatus(1) == 1) )
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
         context.CommitDataStores("IsAuthorizedX");
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
         AV11Context = new SdtContext(context);
         AV14USUARIO = "" ;
         scmdbuf = "" ;
         P000Q2_A116SIS_COD = new short[1] ;
         P000Q2_A6USU_COD = new String[] {""} ;
         A6USU_COD = "" ;
         A152ACW_OBJ = "" ;
         A153ACW_OBS = "" ;
         A154ACW_MOM = (DateTime)(DateTime.MinValue) ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.isauthorizedx__default(),
            new Object[][] {
                new Object[] {
               P000Q2_A116SIS_COD, P000Q2_A6USU_COD
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV13SIS_COD ;
      private short AV12PRG_COD ;
      private short A116SIS_COD ;
      private short A126PRG_COD ;
      private int GX_INS30 ;
      private String AV14USUARIO ;
      private String scmdbuf ;
      private String A6USU_COD ;
      private String Gx_emsg ;
      private DateTime A154ACW_MOM ;
      private bool AV9Authorized ;
      private String A153ACW_OBS ;
      private String GxObject ;
      private String A152ACW_OBJ ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] P000Q2_A116SIS_COD ;
      private String[] P000Q2_A6USU_COD ;
      private bool aP2_Authorized ;
      private SdtContext AV11Context ;
   }

   public class isauthorizedx__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000Q2 ;
          prmP000Q2 = new Object[] {
          new Object[] {"@AV14USUARIO",SqlDbType.Char,16,0} ,
          new Object[] {"@AV13SIS_COD",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmP000Q3 ;
          prmP000Q3 = new Object[] {
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ACW_OBJ",SqlDbType.VarChar,256,0} ,
          new Object[] {"@ACW_OBS",SqlDbType.VarChar,1000,0} ,
          new Object[] {"@ACW_MOM",SqlDbType.DateTime,8,5}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000Q2", "SELECT [SIS_COD], [USU_COD] FROM [SEG003] WITH (NOLOCK) WHERE [USU_COD] = @AV14USUARIO and [SIS_COD] = @AV13SIS_COD ORDER BY [USU_COD], [SIS_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000Q2,1,1,false,true )
             ,new CursorDef("P000Q3", "INSERT INTO [SEG009] ([SIS_COD], [PRG_COD], [ACW_OBJ], [ACW_OBS], [ACW_MOM], [ACW_PRM]) VALUES (@SIS_COD, @PRG_COD, @ACW_OBJ, @ACW_OBS, @ACW_MOM, '')", GxErrorMask.GX_NOMASK,prmP000Q3)
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 16) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (DateTime)parms[4]);
                break;
       }
    }

 }

}
