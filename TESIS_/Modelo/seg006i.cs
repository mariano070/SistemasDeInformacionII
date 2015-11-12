/*
               File: SEG006I
        Description: INSERTA EN SEG006
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 1/6/2014 11:17:34.85
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
   public class seg006i : GXProcedure
   {
      public seg006i( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDESARROLLO = context.GetDataStore("DESARROLLO") ;
         dssoporte_notebook = context.GetDataStore("soporte_notebook") ;
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public seg006i( IGxContext context )
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

      public void execute( ref String aP0_USU_COD ,
                           ref short aP1_SIS_COD ,
                           ref short aP2_PRG_COD ,
                           ref int aP3_PRS_NRO ,
                           ref DateTime aP4_PRS_CAD )
      {
         this.AV12USU_COD = aP0_USU_COD;
         this.AV11SIS_COD = aP1_SIS_COD;
         this.AV10PRG_COD = aP2_PRG_COD;
         this.AV9PRS_NRO = aP3_PRS_NRO;
         this.AV8PRS_CAD = aP4_PRS_CAD;
         initialize();
         executePrivate();
         aP0_USU_COD=this.AV12USU_COD;
         aP1_SIS_COD=this.AV11SIS_COD;
         aP2_PRG_COD=this.AV10PRG_COD;
         aP3_PRS_NRO=this.AV9PRS_NRO;
         aP4_PRS_CAD=this.AV8PRS_CAD;
      }

      public DateTime executeUdp( ref String aP0_USU_COD ,
                                  ref short aP1_SIS_COD ,
                                  ref short aP2_PRG_COD ,
                                  ref int aP3_PRS_NRO )
      {
         this.AV12USU_COD = aP0_USU_COD;
         this.AV11SIS_COD = aP1_SIS_COD;
         this.AV10PRG_COD = aP2_PRG_COD;
         this.AV9PRS_NRO = aP3_PRS_NRO;
         this.AV8PRS_CAD = aP4_PRS_CAD;
         initialize();
         executePrivate();
         aP0_USU_COD=this.AV12USU_COD;
         aP1_SIS_COD=this.AV11SIS_COD;
         aP2_PRG_COD=this.AV10PRG_COD;
         aP3_PRS_NRO=this.AV9PRS_NRO;
         aP4_PRS_CAD=this.AV8PRS_CAD;
         return AV8PRS_CAD ;
      }

      public void executeSubmit( ref String aP0_USU_COD ,
                                 ref short aP1_SIS_COD ,
                                 ref short aP2_PRG_COD ,
                                 ref int aP3_PRS_NRO ,
                                 ref DateTime aP4_PRS_CAD )
      {
         seg006i objseg006i;
         objseg006i = new seg006i();
         objseg006i.AV12USU_COD = aP0_USU_COD;
         objseg006i.AV11SIS_COD = aP1_SIS_COD;
         objseg006i.AV10PRG_COD = aP2_PRG_COD;
         objseg006i.AV9PRS_NRO = aP3_PRS_NRO;
         objseg006i.AV8PRS_CAD = aP4_PRS_CAD;
         objseg006i.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objseg006i.executePrivateCatch ));
         aP0_USU_COD=this.AV12USU_COD;
         aP1_SIS_COD=this.AV11SIS_COD;
         aP2_PRG_COD=this.AV10PRG_COD;
         aP3_PRS_NRO=this.AV9PRS_NRO;
         aP4_PRS_CAD=this.AV8PRS_CAD;
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
         /* Using cursor P000Z2 */
         pr_default.execute(0, new Object[] {AV12USU_COD, AV11SIS_COD, AV10PRG_COD, AV9PRS_NRO});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A118PRS_NRO = P000Z2_A118PRS_NRO[0] ;
            A126PRG_COD = P000Z2_A126PRG_COD[0] ;
            A116SIS_COD = P000Z2_A116SIS_COD[0] ;
            A6USU_COD = P000Z2_A6USU_COD[0] ;
            A165PRS_CAD = P000Z2_A165PRS_CAD[0] ;
            A165PRS_CAD = AV8PRS_CAD ;
            AV13EXISTE = 1 ;
            /* Using cursor P000Z3 */
            pr_default.execute(1, new Object[] {A165PRS_CAD, A6USU_COD, A116SIS_COD, A126PRG_COD, A118PRS_NRO});
            pr_default.close(1);
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         if ( AV13EXISTE == 0 )
         {
            /*
               INSERT RECORD ON TABLE SEG006

            */
            A6USU_COD = AV12USU_COD ;
            A116SIS_COD = AV11SIS_COD ;
            A126PRG_COD = AV10PRG_COD ;
            A118PRS_NRO = AV9PRS_NRO ;
            A165PRS_CAD = AV8PRS_CAD ;
            A166PRS_INI = DateTimeUtil.Now( ) ;
            /* Using cursor P000Z4 */
            pr_default.execute(2, new Object[] {A6USU_COD, A116SIS_COD, A126PRG_COD, A118PRS_NRO, A166PRS_INI, A165PRS_CAD});
            pr_default.close(2);
            if ( (pr_default.getStatus(2) == 1) )
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
         }
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("SEG006I");
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
         scmdbuf = "" ;
         P000Z2_A118PRS_NRO = new int[1] ;
         P000Z2_A126PRG_COD = new short[1] ;
         P000Z2_A116SIS_COD = new short[1] ;
         P000Z2_A6USU_COD = new String[] {""} ;
         P000Z2_A165PRS_CAD = new DateTime[] {DateTime.MinValue} ;
         A6USU_COD = "" ;
         A165PRS_CAD = (DateTime)(DateTime.MinValue) ;
         A166PRS_INI = (DateTime)(DateTime.MinValue) ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.seg006i__default(),
            new Object[][] {
                new Object[] {
               P000Z2_A118PRS_NRO, P000Z2_A126PRG_COD, P000Z2_A116SIS_COD, P000Z2_A6USU_COD, P000Z2_A165PRS_CAD
               }
               , new Object[] {
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV11SIS_COD ;
      private short AV10PRG_COD ;
      private short A126PRG_COD ;
      private short A116SIS_COD ;
      private short AV13EXISTE ;
      private int AV9PRS_NRO ;
      private int A118PRS_NRO ;
      private int GX_INS34 ;
      private String AV12USU_COD ;
      private String scmdbuf ;
      private String A6USU_COD ;
      private String Gx_emsg ;
      private DateTime AV8PRS_CAD ;
      private DateTime A165PRS_CAD ;
      private DateTime A166PRS_INI ;
      private IGxDataStore dsDESARROLLO ;
      private IGxDataStore dssoporte_notebook ;
      private IGxDataStore dsDefault ;
      private String aP0_USU_COD ;
      private short aP1_SIS_COD ;
      private short aP2_PRG_COD ;
      private int aP3_PRS_NRO ;
      private DateTime aP4_PRS_CAD ;
      private IDataStoreProvider pr_default ;
      private int[] P000Z2_A118PRS_NRO ;
      private short[] P000Z2_A126PRG_COD ;
      private short[] P000Z2_A116SIS_COD ;
      private String[] P000Z2_A6USU_COD ;
      private DateTime[] P000Z2_A165PRS_CAD ;
   }

   public class seg006i__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
         ,new UpdateCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP000Z2 ;
          prmP000Z2 = new Object[] {
          new Object[] {"@AV12USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@AV11SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV10PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9PRS_NRO",SqlDbType.Int,8,0}
          } ;
          Object[] prmP000Z3 ;
          prmP000Z3 = new Object[] {
          new Object[] {"@PRS_CAD",SqlDbType.DateTime,8,5} ,
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PRS_NRO",SqlDbType.Int,8,0}
          } ;
          Object[] prmP000Z4 ;
          prmP000Z4 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0} ,
          new Object[] {"@SIS_COD",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@PRG_COD",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@PRS_NRO",SqlDbType.Int,8,0} ,
          new Object[] {"@PRS_INI",SqlDbType.DateTime,8,5} ,
          new Object[] {"@PRS_CAD",SqlDbType.DateTime,8,5}
          } ;
          def= new CursorDef[] {
              new CursorDef("P000Z2", "SELECT [PRS_NRO], [PRG_COD], [SIS_COD], [USU_COD], [PRS_CAD] FROM [SEG006] WITH (UPDLOCK) WHERE [USU_COD] = @AV12USU_COD and [SIS_COD] = @AV11SIS_COD and [PRG_COD] = @AV10PRG_COD and [PRS_NRO] = @AV9PRS_NRO ORDER BY [USU_COD], [SIS_COD], [PRG_COD], [PRS_NRO] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP000Z2,1,1,true,true )
             ,new CursorDef("P000Z3", "UPDATE [SEG006] SET [PRS_CAD]=@PRS_CAD  WHERE [USU_COD] = @USU_COD AND [SIS_COD] = @SIS_COD AND [PRG_COD] = @PRG_COD AND [PRS_NRO] = @PRS_NRO", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP000Z3)
             ,new CursorDef("P000Z4", "INSERT INTO [SEG006] ([USU_COD], [SIS_COD], [PRG_COD], [PRS_NRO], [PRS_INI], [PRS_CAD], [PRS_UOB], [PRS_UDE], [PRS_ULNK]) VALUES (@USU_COD, @SIS_COD, @PRG_COD, @PRS_NRO, @PRS_INI, @PRS_CAD, '', '', '')", GxErrorMask.GX_NOMASK,prmP000Z4)
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 16) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDateTime(5) ;
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
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                break;
             case 1 :
                stmt.SetParameter(1, (DateTime)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (int)parms[4]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                stmt.SetParameter(5, (DateTime)parms[4]);
                stmt.SetParameter(6, (DateTime)parms[5]);
                break;
       }
    }

 }

}
