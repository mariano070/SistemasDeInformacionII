/*
               File: PTBUSSEG3
        Description: Alta en TTBUS007
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:29:57.68
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
   public class ptbusseg3 : GXProcedure
   {
      public ptbusseg3( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ptbusseg3( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref short aP0_W53POS ,
                           ref String aP1_USU_COD ,
                           ref short aP2_Responsable ,
                           ref String aP3_Modo )
      {
         this.AV8W53POS = aP0_W53POS;
         this.AV9USU_COD = aP1_USU_COD;
         this.AV11Responsable = aP2_Responsable;
         this.AV10Modo = aP3_Modo;
         initialize();
         executePrivate();
         aP0_W53POS=this.AV8W53POS;
         aP1_USU_COD=this.AV9USU_COD;
         aP2_Responsable=this.AV11Responsable;
         aP3_Modo=this.AV10Modo;
      }

      public String executeUdp( ref short aP0_W53POS ,
                                ref String aP1_USU_COD ,
                                ref short aP2_Responsable )
      {
         this.AV8W53POS = aP0_W53POS;
         this.AV9USU_COD = aP1_USU_COD;
         this.AV11Responsable = aP2_Responsable;
         this.AV10Modo = aP3_Modo;
         initialize();
         executePrivate();
         aP0_W53POS=this.AV8W53POS;
         aP1_USU_COD=this.AV9USU_COD;
         aP2_Responsable=this.AV11Responsable;
         aP3_Modo=this.AV10Modo;
         return AV10Modo ;
      }

      public void executeSubmit( ref short aP0_W53POS ,
                                 ref String aP1_USU_COD ,
                                 ref short aP2_Responsable ,
                                 ref String aP3_Modo )
      {
         ptbusseg3 objptbusseg3;
         objptbusseg3 = new ptbusseg3();
         objptbusseg3.AV8W53POS = aP0_W53POS;
         objptbusseg3.AV9USU_COD = aP1_USU_COD;
         objptbusseg3.AV11Responsable = aP2_Responsable;
         objptbusseg3.AV10Modo = aP3_Modo;
         objptbusseg3.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbusseg3.executePrivateCatch ));
         aP0_W53POS=this.AV8W53POS;
         aP1_USU_COD=this.AV9USU_COD;
         aP2_Responsable=this.AV11Responsable;
         aP3_Modo=this.AV10Modo;
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
         if ( StringUtil.StrCmp(AV10Modo, "INS") == 0 )
         {
            if ( AV11Responsable == 1 )
            {
               /*
                  INSERT RECORD ON TABLE TTBUS007

               */
               A33TTBUS7_Pos = AV8W53POS ;
               A35TTBUS7_CodResp = AV9USU_COD ;
               /* Using cursor P002O2 */
               pr_default.execute(0, new Object[] {A33TTBUS7_Pos, A35TTBUS7_CodResp});
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
            }
         }
         else if ( StringUtil.StrCmp(AV10Modo, "UPD") == 0 )
         {
            AV14GXLvl12 = 0 ;
            /* Using cursor P002O3 */
            pr_default.execute(1, new Object[] {AV8W53POS, AV9USU_COD});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A35TTBUS7_CodResp = P002O3_A35TTBUS7_CodResp[0] ;
               A33TTBUS7_Pos = P002O3_A33TTBUS7_Pos[0] ;
               AV14GXLvl12 = 1 ;
               if ( AV11Responsable == 0 )
               {
                  /* Using cursor P002O4 */
                  pr_default.execute(2, new Object[] {A33TTBUS7_Pos});
                  pr_default.close(2);
               }
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(1);
            if ( AV14GXLvl12 == 0 )
            {
               if ( AV11Responsable == 1 )
               {
                  /*
                     INSERT RECORD ON TABLE TTBUS007

                  */
                  A33TTBUS7_Pos = AV8W53POS ;
                  A35TTBUS7_CodResp = AV9USU_COD ;
                  /* Using cursor P002O5 */
                  pr_default.execute(3, new Object[] {A33TTBUS7_Pos, A35TTBUS7_CodResp});
                  pr_default.close(3);
                  if ( (pr_default.getStatus(3) == 1) )
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
            }
         }
         else if ( StringUtil.StrCmp(AV10Modo, "DLT") == 0 )
         {
            /* Optimized DELETE. */
            /* Using cursor P002O6 */
            pr_default.execute(4, new Object[] {AV8W53POS, AV9USU_COD});
            pr_default.close(4);
            /* End optimized DELETE. */
         }
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("PTBUSSEG3");
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
         A35TTBUS7_CodResp = "" ;
         Gx_emsg = "" ;
         scmdbuf = "" ;
         P002O3_A35TTBUS7_CodResp = new String[] {""} ;
         P002O3_A33TTBUS7_Pos = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ptbusseg3__default(),
            new Object[][] {
                new Object[] {
               }
               , new Object[] {
               P002O3_A35TTBUS7_CodResp, P002O3_A33TTBUS7_Pos
               }
               , new Object[] {
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

      private short AV8W53POS ;
      private short AV11Responsable ;
      private short A33TTBUS7_Pos ;
      private short AV14GXLvl12 ;
      private int GX_INS7 ;
      private String AV9USU_COD ;
      private String AV10Modo ;
      private String A35TTBUS7_CodResp ;
      private String Gx_emsg ;
      private String scmdbuf ;
      private IGxDataStore dsDefault ;
      private short aP0_W53POS ;
      private String aP1_USU_COD ;
      private short aP2_Responsable ;
      private String aP3_Modo ;
      private IDataStoreProvider pr_default ;
      private String[] P002O3_A35TTBUS7_CodResp ;
      private short[] P002O3_A33TTBUS7_Pos ;
   }

   public class ptbusseg3__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new UpdateCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new UpdateCursor(def[2])
         ,new UpdateCursor(def[3])
         ,new UpdateCursor(def[4])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP002O2 ;
          prmP002O2 = new Object[] {
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@TTBUS7_CodResp",SqlDbType.Char,16,0}
          } ;
          Object[] prmP002O3 ;
          prmP002O3 = new Object[] {
          new Object[] {"@AV8W53POS",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV9USU_COD",SqlDbType.Char,16,0}
          } ;
          Object[] prmP002O4 ;
          prmP002O4 = new Object[] {
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0}
          } ;
          Object[] prmP002O5 ;
          prmP002O5 = new Object[] {
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@TTBUS7_CodResp",SqlDbType.Char,16,0}
          } ;
          Object[] prmP002O6 ;
          prmP002O6 = new Object[] {
          new Object[] {"@AV8W53POS",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV9USU_COD",SqlDbType.Char,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P002O2", "INSERT INTO [TTBUS007] ([TTBUS7_Pos], [TTBUS7_CodResp]) VALUES (@TTBUS7_Pos, @TTBUS7_CodResp)", GxErrorMask.GX_NOMASK,prmP002O2)
             ,new CursorDef("P002O3", "SELECT [TTBUS7_CodResp], [TTBUS7_Pos] FROM [TTBUS007] WITH (UPDLOCK) WHERE ([TTBUS7_Pos] = @AV8W53POS) AND ([TTBUS7_CodResp] = @AV9USU_COD) ORDER BY [TTBUS7_Pos] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002O3,1,0,true,true )
             ,new CursorDef("P002O4", "DELETE FROM [TTBUS007]  WHERE [TTBUS7_Pos] = @TTBUS7_Pos", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002O4)
             ,new CursorDef("P002O5", "INSERT INTO [TTBUS007] ([TTBUS7_Pos], [TTBUS7_CodResp]) VALUES (@TTBUS7_Pos, @TTBUS7_CodResp)", GxErrorMask.GX_NOMASK,prmP002O5)
             ,new CursorDef("P002O6", "DELETE FROM [TTBUS007]  WHERE ([TTBUS7_Pos] = @AV8W53POS) AND ([TTBUS7_CodResp] = @AV9USU_COD)", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002O6)
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
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
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
       }
    }

 }

}
