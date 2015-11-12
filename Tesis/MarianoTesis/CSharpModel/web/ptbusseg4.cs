/*
               File: PTBUSSEG4
        Description: ALTA EN TTBUS007PERMISOS
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:29:57.81
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
   public class ptbusseg4 : GXProcedure
   {
      public ptbusseg4( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public ptbusseg4( IGxContext context )
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
                           ref short aP2_TTBUS7_RESPAUX ,
                           ref short aP3_Permiso ,
                           ref String aP4_Modo )
      {
         this.AV9W53POS = aP0_W53POS;
         this.AV8USU_COD = aP1_USU_COD;
         this.AV10TTBUS7_RESPAUX = aP2_TTBUS7_RESPAUX;
         this.AV12Permiso = aP3_Permiso;
         this.AV11Modo = aP4_Modo;
         initialize();
         executePrivate();
         aP0_W53POS=this.AV9W53POS;
         aP1_USU_COD=this.AV8USU_COD;
         aP2_TTBUS7_RESPAUX=this.AV10TTBUS7_RESPAUX;
         aP3_Permiso=this.AV12Permiso;
         aP4_Modo=this.AV11Modo;
      }

      public String executeUdp( ref short aP0_W53POS ,
                                ref String aP1_USU_COD ,
                                ref short aP2_TTBUS7_RESPAUX ,
                                ref short aP3_Permiso )
      {
         this.AV9W53POS = aP0_W53POS;
         this.AV8USU_COD = aP1_USU_COD;
         this.AV10TTBUS7_RESPAUX = aP2_TTBUS7_RESPAUX;
         this.AV12Permiso = aP3_Permiso;
         this.AV11Modo = aP4_Modo;
         initialize();
         executePrivate();
         aP0_W53POS=this.AV9W53POS;
         aP1_USU_COD=this.AV8USU_COD;
         aP2_TTBUS7_RESPAUX=this.AV10TTBUS7_RESPAUX;
         aP3_Permiso=this.AV12Permiso;
         aP4_Modo=this.AV11Modo;
         return AV11Modo ;
      }

      public void executeSubmit( ref short aP0_W53POS ,
                                 ref String aP1_USU_COD ,
                                 ref short aP2_TTBUS7_RESPAUX ,
                                 ref short aP3_Permiso ,
                                 ref String aP4_Modo )
      {
         ptbusseg4 objptbusseg4;
         objptbusseg4 = new ptbusseg4();
         objptbusseg4.AV9W53POS = aP0_W53POS;
         objptbusseg4.AV8USU_COD = aP1_USU_COD;
         objptbusseg4.AV10TTBUS7_RESPAUX = aP2_TTBUS7_RESPAUX;
         objptbusseg4.AV12Permiso = aP3_Permiso;
         objptbusseg4.AV11Modo = aP4_Modo;
         objptbusseg4.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objptbusseg4.executePrivateCatch ));
         aP0_W53POS=this.AV9W53POS;
         aP1_USU_COD=this.AV8USU_COD;
         aP2_TTBUS7_RESPAUX=this.AV10TTBUS7_RESPAUX;
         aP3_Permiso=this.AV12Permiso;
         aP4_Modo=this.AV11Modo;
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
         if ( StringUtil.StrCmp(AV11Modo, "INS") == 0 )
         {
            if ( AV12Permiso == 1 )
            {
               /*
                  INSERT RECORD ON TABLE TTBUS007Permisos

               */
               A33TTBUS7_Pos = AV9W53POS ;
               A39TTBUS7_CodUsuario = AV8USU_COD ;
               A51TTBUS7_RespAux = AV10TTBUS7_RESPAUX ;
               /* Using cursor P002P2 */
               pr_default.execute(0, new Object[] {A33TTBUS7_Pos, A39TTBUS7_CodUsuario, A51TTBUS7_RespAux});
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
         else if ( StringUtil.StrCmp(AV11Modo, "UPD") == 0 )
         {
            AV15GXLvl13 = 0 ;
            /* Using cursor P002P3 */
            pr_default.execute(1, new Object[] {AV9W53POS, AV8USU_COD});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A39TTBUS7_CodUsuario = P002P3_A39TTBUS7_CodUsuario[0] ;
               A33TTBUS7_Pos = P002P3_A33TTBUS7_Pos[0] ;
               AV15GXLvl13 = 1 ;
               if ( AV12Permiso == 0 )
               {
                  /* Using cursor P002P4 */
                  pr_default.execute(2, new Object[] {A33TTBUS7_Pos, A39TTBUS7_CodUsuario});
                  pr_default.close(2);
               }
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(1);
            if ( AV15GXLvl13 == 0 )
            {
               if ( AV12Permiso == 1 )
               {
                  /*
                     INSERT RECORD ON TABLE TTBUS007Permisos

                  */
                  A33TTBUS7_Pos = AV9W53POS ;
                  A39TTBUS7_CodUsuario = AV8USU_COD ;
                  A51TTBUS7_RespAux = AV10TTBUS7_RESPAUX ;
                  /* Using cursor P002P5 */
                  pr_default.execute(3, new Object[] {A33TTBUS7_Pos, A39TTBUS7_CodUsuario, A51TTBUS7_RespAux});
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
         else if ( StringUtil.StrCmp(AV11Modo, "DLT") == 0 )
         {
            /* Optimized DELETE. */
            /* Using cursor P002P6 */
            pr_default.execute(4, new Object[] {AV9W53POS, AV8USU_COD});
            pr_default.close(4);
            /* End optimized DELETE. */
         }
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("PTBUSSEG4");
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
         A39TTBUS7_CodUsuario = "" ;
         Gx_emsg = "" ;
         scmdbuf = "" ;
         P002P3_A39TTBUS7_CodUsuario = new String[] {""} ;
         P002P3_A33TTBUS7_Pos = new short[1] ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.ptbusseg4__default(),
            new Object[][] {
                new Object[] {
               }
               , new Object[] {
               P002P3_A39TTBUS7_CodUsuario, P002P3_A33TTBUS7_Pos
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

      private short AV9W53POS ;
      private short AV10TTBUS7_RESPAUX ;
      private short AV12Permiso ;
      private short A33TTBUS7_Pos ;
      private short A51TTBUS7_RespAux ;
      private short AV15GXLvl13 ;
      private int GX_INS8 ;
      private String AV8USU_COD ;
      private String AV11Modo ;
      private String A39TTBUS7_CodUsuario ;
      private String Gx_emsg ;
      private String scmdbuf ;
      private IGxDataStore dsDefault ;
      private short aP0_W53POS ;
      private String aP1_USU_COD ;
      private short aP2_TTBUS7_RESPAUX ;
      private short aP3_Permiso ;
      private String aP4_Modo ;
      private IDataStoreProvider pr_default ;
      private String[] P002P3_A39TTBUS7_CodUsuario ;
      private short[] P002P3_A33TTBUS7_Pos ;
   }

   public class ptbusseg4__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmP002P2 ;
          prmP002P2 = new Object[] {
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@TTBUS7_CodUsuario",SqlDbType.Char,16,0} ,
          new Object[] {"@TTBUS7_RespAux",SqlDbType.SmallInt,1,0}
          } ;
          Object[] prmP002P3 ;
          prmP002P3 = new Object[] {
          new Object[] {"@AV9W53POS",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV8USU_COD",SqlDbType.Char,16,0}
          } ;
          Object[] prmP002P4 ;
          prmP002P4 = new Object[] {
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@TTBUS7_CodUsuario",SqlDbType.Char,16,0}
          } ;
          Object[] prmP002P5 ;
          prmP002P5 = new Object[] {
          new Object[] {"@TTBUS7_Pos",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@TTBUS7_CodUsuario",SqlDbType.Char,16,0} ,
          new Object[] {"@TTBUS7_RespAux",SqlDbType.SmallInt,1,0}
          } ;
          Object[] prmP002P6 ;
          prmP002P6 = new Object[] {
          new Object[] {"@AV9W53POS",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV8USU_COD",SqlDbType.Char,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P002P2", "INSERT INTO [TTBUS007Permisos] ([TTBUS7_Pos], [TTBUS7_CodUsuario], [TTBUS7_RespAux]) VALUES (@TTBUS7_Pos, @TTBUS7_CodUsuario, @TTBUS7_RespAux)", GxErrorMask.GX_NOMASK,prmP002P2)
             ,new CursorDef("P002P3", "SELECT [TTBUS7_CodUsuario], [TTBUS7_Pos] FROM [TTBUS007Permisos] WITH (UPDLOCK) WHERE [TTBUS7_Pos] = @AV9W53POS and [TTBUS7_CodUsuario] = @AV8USU_COD ORDER BY [TTBUS7_Pos], [TTBUS7_CodUsuario] ",true, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP002P3,1,0,true,true )
             ,new CursorDef("P002P4", "DELETE FROM [TTBUS007Permisos]  WHERE [TTBUS7_Pos] = @TTBUS7_Pos AND [TTBUS7_CodUsuario] = @TTBUS7_CodUsuario", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002P4)
             ,new CursorDef("P002P5", "INSERT INTO [TTBUS007Permisos] ([TTBUS7_Pos], [TTBUS7_CodUsuario], [TTBUS7_RespAux]) VALUES (@TTBUS7_Pos, @TTBUS7_CodUsuario, @TTBUS7_RespAux)", GxErrorMask.GX_NOMASK,prmP002P5)
             ,new CursorDef("P002P6", "DELETE FROM [TTBUS007Permisos]  WHERE [TTBUS7_Pos] = @AV9W53POS and [TTBUS7_CodUsuario] = @AV8USU_COD", GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK,prmP002P6)
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
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                break;
       }
    }

 }

}
