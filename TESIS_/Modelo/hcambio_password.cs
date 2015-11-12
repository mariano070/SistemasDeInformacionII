/*
               File: HCAMBIO_password
        Description: Modificación de Contraseña
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 3/17/2014 13:22:36.17
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
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class hcambio_password : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public hcambio_password( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public hcambio_password( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_USU_COD )
      {
         this.A6USU_COD = aP0_USU_COD;
         executePrivate();
         aP0_USU_COD=this.A6USU_COD;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( nGotPars == 0 )
         {
            entryPointCalled = false ;
            gxfirstwebparm = GetNextPar( ) ;
            gxfirstwebparm_bkp = gxfirstwebparm ;
            gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm, "High") ;
            if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
            {
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               dyncall( GetNextPar( )) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
            {
               setAjaxEventMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxfirstwebparm = GetNextPar( ) ;
            }
            else
            {
               if ( ! IsValidAjaxCall( false) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxfirstwebparm = gxfirstwebparm_bkp ;
            }
            if ( ! entryPointCalled )
            {
               A6USU_COD = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
            }
         }
         context.SetTheme("Modern");
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITWEB( ) ;
         if ( ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("promptmasterpage", "GeneXus.Programs.promptmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
            MasterPageObj.webExecute();
            if ( context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
               }
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) )
               {
                  context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               }
               else
               {
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      public override short ExecuteStartEvent( )
      {
         PA242( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START242( ) ;
         }
         return gxajaxcallmode ;
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, "IE=EmulateIE7");
      }

      public override void RenderHtmlOpenForm( )
      {
         context.WriteHtmlText( "<title>") ;
         context.WriteHtmlText( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         if ( nGXWrapped != 1 )
         {
            MasterPageObj.master_styles();
         }
         if ( ! context.isSmartDevice( ) )
         {
            context.AddJavascriptSource("gxgral.js", "?42940");
            context.AddJavascriptSource("gxcfg.js", "?42940");
         }
         else
         {
            context.AddJavascriptSource("gxapiSD.js", "?42940");
            context.AddJavascriptSource("gxfxSD.js", "?42940");
            context.AddJavascriptSource("gxtypesSD.js", "?42940");
            context.AddJavascriptSource("gxpopupSD.js", "?42940");
            context.AddJavascriptSource("gxfrmutlSD.js", "?42940");
            context.AddJavascriptSource("gxgridSD.js", "?42940");
            context.AddJavascriptSource("JavaScripTableSD.js", "?42940");
            context.AddJavascriptSource("rijndaelSD.js", "?42940");
            context.AddJavascriptSource("gxgralSD.js", "?42940");
            context.AddJavascriptSource("gxcfg.js", "?42940");
         }
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,false,false)\" onkeydown=\"gx.evt.onkeypress(null,false,false)\"" ;
         context.WriteHtmlText( "<body") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background=\""+context.convertURL( Form.Background)+"\"") ;
         }
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+"\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("hcambio_password.aspx") + "?" + UrlEncode(StringUtil.RTrim(A6USU_COD))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendComponentObjects();
         SendServerCommands();
         SendState();
         context.WriteHtmlTextNl( "</form>") ;
         include_jscripts( ) ;
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            WE242( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT242( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "HCAMBIO_password" ;
      }

      public override String GetPgmdesc( )
      {
         return "Modificación de Contraseña" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("hcambio_password.aspx") + "?" + UrlEncode(StringUtil.RTrim(A6USU_COD)) ;
      }

      protected void WB240( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( nGXWrapped == 1 )
            {
               RenderHtmlHeaders( ) ;
               RenderHtmlOpenForm( ) ;
            }
            context.WriteHtmlText( "<p>") ;
            wb_table1_3_242( true) ;
         }
         else
         {
            wb_table1_3_242( false) ;
         }
         return  ;
      }

      protected void wb_table1_3_242e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</p>") ;
         }
         wbLoad = true ;
      }

      protected void START242( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "Modificación de Contraseña", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP240( ) ;
      }

      protected void WS242( )
      {
         START242( ) ;
         EVT242( ) ;
      }

      protected void EVT242( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               sEvt = cgiGet( "_EventName") ;
               EvtGridId = cgiGet( "_EventGridId") ;
               EvtRowId = cgiGet( "_EventRowId") ;
               if ( StringUtil.Len( sEvt) > 0 )
               {
                  sEvtType = StringUtil.Left( sEvt, 1) ;
                  sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                  if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
                  {
                     if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                     {
                        sEvtType = StringUtil.Right( sEvt, 1) ;
                        if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                        {
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E11242 */
                              E11242 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'CAMBIAR'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E12242 */
                              E12242 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E13242 */
                              E13242 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              context.wbHandled = 1 ;
                              if ( ! wbErr )
                              {
                                 Rfr0gs = false ;
                                 if ( ! Rfr0gs )
                                 {
                                 }
                                 dynload_actions( ) ;
                              }
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                        }
                     }
                     context.wbHandled = 1 ;
                  }
               }
            }
         }
      }

      protected void WE242( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               if ( nGXWrapped == 1 )
               {
                  RenderHtmlCloseForm( ) ;
               }
            }
         }
      }

      protected void PA242( )
      {
         if ( nDonePA == 0 )
         {
            GX_FocusControl = edtavUsu_cla_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void Refresh( )
      {
         RF242( ) ;
         /* End function Refresh */
      }

      protected void RF242( )
      {
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H00242 */
            pr_default.execute(0, new Object[] {A6USU_COD});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A7USU_DES = H00242_A7USU_DES[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
               /* Execute user event: E13242 */
               E13242 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            WB240( ) ;
         }
      }

      protected void STRUP240( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E11242 */
         E11242 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            A6USU_COD = StringUtil.Upper( cgiGet( edtUSU_COD_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
            A7USU_DES = StringUtil.Upper( cgiGet( edtUSU_DES_Internalname)) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A7USU_DES", A7USU_DES);
            AV11USU_CLA = cgiGet( edtavUsu_cla_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11USU_CLA", AV11USU_CLA);
            AV10USUNCL = cgiGet( edtavUsuncl_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10USUNCL", AV10USUNCL);
            AV12USU_CRT = cgiGet( edtavUsu_crt_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12USU_CRT", AV12USU_CRT);
            /* Read saved values. */
            /* Read subfile selected row values. */
            /* Read hidden variables. */
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: E11242 */
         E11242 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E11242( )
      {
         /* Start Routine */
         AV15CODIGO = A6USU_COD ;
         edtavUsu_cla_Ispassword = 1 ;
         edtavUsu_crt_Ispassword = 1 ;
         edtavUsuncl_Ispassword = 1 ;
         /* Execute user subroutine: S112 */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E12242( )
      {
         /* 'Cambiar' Routine */
         AV9SENIAL = 0 ;
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( A7USU_DES)) )
         {
            if ( ( StringUtil.StrCmp(StringUtil.Trim( StringUtil.Upper( AV11USU_CLA)), StringUtil.Upper( AV14CLAVE)) == 0 ) && ! String.IsNullOrEmpty(StringUtil.RTrim( AV11USU_CLA)) )
            {
               if ( ( StringUtil.StrCmp(AV10USUNCL, StringUtil.Space( 8)) != 0 ) && ( StringUtil.StrCmp(AV10USUNCL, AV14CLAVE) != 0 ) && ( StringUtil.StrCmp(AV10USUNCL, AV12USU_CRT) == 0 ) )
               {
                  new pseg011(context ).execute( ref  A6USU_COD, ref  AV10USUNCL) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10USUNCL", AV10USUNCL);
                  AV9SENIAL = 1 ;
               }
               if ( AV9SENIAL == 1 )
               {
                  GX_msglist.addItem("La Contraseña se ha Cambiado con Exito.");
               }
               else
               {
                  if ( ( StringUtil.StrCmp(AV10USUNCL, AV14CLAVE) == 0 ) || ( StringUtil.StrCmp(AV10USUNCL, StringUtil.Space( 8)) == 0 ) )
                  {
                     GX_msglist.addItem("Debe Especificar una Contraseña NUEVA.");
                  }
                  else
                  {
                     if ( StringUtil.StrCmp(AV12USU_CRT, AV10USUNCL) != 0 )
                     {
                        GX_msglist.addItem("Para control debe Repetir LA MISMA Contraseña en los Casilleros de Color Verde.");
                     }
                  }
               }
            }
            else
            {
               GX_msglist.addItem("La Contraseña ACTUAL es Incorrecta.");
            }
         }
         else
         {
            GX_msglist.addItem("El Usuario NO EXISTE.");
         }
      }

      protected void S112( )
      {
         /* 'CLAVE' Routine */
         /* Using cursor H00243 */
         pr_default.execute(1, new Object[] {AV15CODIGO});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A155USU_CLA = H00243_A155USU_CLA[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155USU_CLA", A155USU_CLA);
            AV14CLAVE = A155USU_CLA ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(1);
      }

      protected void nextLoad( )
      {
      }

      protected void E13242( )
      {
         /* Load Routine */
      }

      protected void wb_table1_3_242( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            sStyleString = sStyleString + "border:" + StringUtil.Str( (decimal)(1), 3, 0) + "px solid;" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 1, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td bordercolor=\"#00C0C0\" >") ;
            wb_table2_6_242( true) ;
         }
         else
         {
            wb_table2_6_242( false) ;
         }
         return  ;
      }

      protected void wb_table2_6_242e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_3_242e( true) ;
         }
         else
         {
            wb_table1_3_242e( false) ;
         }
      }

      protected void wb_table2_6_242( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"3\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock4_Internalname, 1, 1, 0, "Usuario:", "", "", "", 0, lblTextblock4_Jsonclick, "", StyleString, ClassString, "HLP_HCAMBIO_password.htm");
            context.WriteHtmlText( "&nbsp; ") ;
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Verdana'; font-size:9.0pt; font-weight:bold; font-style:normal; color:#8080FF" ;
            GxWebStd.gx_single_line_edit( context, edtUSU_COD_Internalname, StringUtil.RTrim( A6USU_COD), "", 16, "chr", 1, "row", 16, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A6USU_COD, "@!")), "", 0, edtUSU_COD_Jsonclick, "", 0, 1, 1, true, "left", "HLP_HCAMBIO_password.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"3\"  style=\"height:25px\">") ;
            context.WriteHtmlText( "<p>") ;
            /* Single line edit */
            ClassString = "Nombre_programa" ;
            StyleString = "font-family:'Verdana'; font-size:8.0pt; font-weight:bold; font-style:normal; color:#8080FF" ;
            GxWebStd.gx_single_line_edit( context, edtUSU_DES_Internalname, StringUtil.RTrim( A7USU_DES), "", 50, "chr", 1, "row", 50, 1, 0, 0, 0, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( A7USU_DES, "@!")), "", 0, edtUSU_DES_Jsonclick, "", 0, 1, 1, true, "left", "HLP_HCAMBIO_password.htm");
            context.WriteHtmlText( "</p>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"3\"  style=\"height:34px\">") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, 1, 1, 0, "Contraseña Anterior:", "", "", "", 0, lblTextblock1_Jsonclick, "", StyleString, ClassString, "HLP_HCAMBIO_password.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavUsu_cla_Internalname, StringUtil.RTrim( AV11USU_CLA), "", 20, "chr", 1, "row", 20, 1, 1, 0, edtavUsu_cla_Ispassword, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV11USU_CLA, "XXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(21);\"", 0, edtavUsu_cla_Jsonclick, "", 0, 1, -1, true, "left", "HLP_HCAMBIO_password.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, 1, 1, 0, "Contraseña Nueva:", "", "", "", 0, lblTextblock2_Jsonclick, "", StyleString, ClassString, "HLP_HCAMBIO_password.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "background:#80FF80" ;
            GxWebStd.gx_single_line_edit( context, edtavUsuncl_Internalname, StringUtil.RTrim( AV10USUNCL), "", 20, "chr", 1, "row", 20, 1, 1, 0, edtavUsuncl_Ispassword, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV10USUNCL, "XXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(27);\"", 0, edtavUsuncl_Jsonclick, "", 0, 1, -1, true, "left", "HLP_HCAMBIO_password.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock3_Internalname, 1, 1, 0, "Repetir Contraseña Nueva:", "", "", "", 0, lblTextblock3_Jsonclick, "", StyleString, ClassString, "HLP_HCAMBIO_password.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "background:#80FF80" ;
            GxWebStd.gx_single_line_edit( context, edtavUsu_crt_Internalname, StringUtil.RTrim( AV12USU_CRT), "", 20, "chr", 1, "row", 20, 1, 1, 0, edtavUsu_crt_Ispassword, 0, "", "", StyleString, ClassString, "", StringUtil.RTrim( context.localUtil.Format( AV12USU_CRT, "XXXXXXXXXXXXXXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(33);\"", 0, edtavUsu_crt_Jsonclick, "", 0, 1, -1, true, "left", "HLP_HCAMBIO_password.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\"  style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            context.WriteHtmlText( "&nbsp; ") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, context.GetButtonType( ), bttButton1_Internalname, "Cambiar", "Cambiar", "", StyleString, ClassString, 1, 1, "rounded", 5, bttButton1_Jsonclick, "E\\'CAMBIAR\\'.", TempTags, "", "", "HLP_HCAMBIO_password.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_6_242e( true) ;
         }
         else
         {
            wb_table2_6_242e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         A6USU_COD = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A6USU_COD", A6USU_COD);
      }

      public override String getresponse( String sGXDynURL )
      {
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         sDynURL = sGXDynURL ;
         nGotPars = (short)(1) ;
         nGXWrapped = (short)(1) ;
         context.SetWrapped(true);
         PA242( ) ;
         WS242( ) ;
         WE242( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst ;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Modern.css", "?2051812");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?13223633");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("hcambio_password.js", "?13223633");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTextblock4_Internalname = "TEXTBLOCK4" ;
         edtUSU_COD_Internalname = "USU_COD" ;
         edtUSU_DES_Internalname = "USU_DES" ;
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         edtavUsu_cla_Internalname = "vUSU_CLA" ;
         lblTextblock2_Internalname = "TEXTBLOCK2" ;
         edtavUsuncl_Internalname = "vUSUNCL" ;
         lblTextblock3_Internalname = "TEXTBLOCK3" ;
         edtavUsu_crt_Internalname = "vUSU_CRT" ;
         bttButton1_Internalname = "BUTTON1" ;
         tblTable1_Internalname = "TABLE1" ;
         tblTable2_Internalname = "TABLE2" ;
         Form.Internalname = "FORM" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtavUsu_crt_Jsonclick = "" ;
         edtavUsu_crt_Backstyle = -1 ;
         edtavUsu_crt_Backcolor = (int)(0x80FF80) ;
         edtavUsu_crt_Ispassword = -1 ;
         edtavUsuncl_Jsonclick = "" ;
         edtavUsuncl_Backstyle = -1 ;
         edtavUsuncl_Backcolor = (int)(0x80FF80) ;
         edtavUsuncl_Ispassword = -1 ;
         edtavUsu_cla_Jsonclick = "" ;
         edtavUsu_cla_Ispassword = -1 ;
         edtUSU_DES_Jsonclick = "" ;
         edtUSU_COD_Jsonclick = "" ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Modificación de Contraseña" ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void cleanup( )
      {
         flushBuffer();
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
         wcpOA6USU_COD = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char1 = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         scmdbuf = "" ;
         H00242_A6USU_COD = new String[] {""} ;
         H00242_A7USU_DES = new String[] {""} ;
         A7USU_DES = "" ;
         AV11USU_CLA = "" ;
         AV10USUNCL = "" ;
         AV12USU_CRT = "" ;
         AV15CODIGO = "" ;
         AV14CLAVE = "" ;
         H00243_A6USU_COD = new String[] {""} ;
         H00243_A155USU_CLA = new String[] {""} ;
         A155USU_CLA = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         lblTextblock4_Jsonclick = "" ;
         lblTextblock1_Jsonclick = "" ;
         TempTags = "" ;
         lblTextblock2_Jsonclick = "" ;
         lblTextblock3_Jsonclick = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         bttButton1_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.hcambio_password__default(),
            new Object[][] {
                new Object[] {
               H00242_A6USU_COD, H00242_A7USU_DES
               }
               , new Object[] {
               H00243_A6USU_COD, H00243_A155USU_CLA
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short edtavUsu_cla_Ispassword ;
      private short edtavUsu_crt_Ispassword ;
      private short edtavUsuncl_Ispassword ;
      private short AV9SENIAL ;
      private short nGXWrapped ;
      private short edtavUsu_crt_Backstyle ;
      private short edtavUsuncl_Backstyle ;
      private int idxLst ;
      private int edtavUsu_crt_Backcolor ;
      private int edtavUsuncl_Backcolor ;
      private String A6USU_COD ;
      private String wcpOA6USU_COD ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char1 ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavUsu_cla_Internalname ;
      private String scmdbuf ;
      private String A7USU_DES ;
      private String edtUSU_COD_Internalname ;
      private String edtUSU_DES_Internalname ;
      private String AV11USU_CLA ;
      private String AV10USUNCL ;
      private String edtavUsuncl_Internalname ;
      private String AV12USU_CRT ;
      private String edtavUsu_crt_Internalname ;
      private String AV15CODIGO ;
      private String AV14CLAVE ;
      private String A155USU_CLA ;
      private String sStyleString ;
      private String tblTable2_Internalname ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String lblTextblock4_Internalname ;
      private String lblTextblock4_Jsonclick ;
      private String edtUSU_COD_Jsonclick ;
      private String edtUSU_DES_Jsonclick ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String TempTags ;
      private String edtavUsu_cla_Jsonclick ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String edtavUsuncl_Jsonclick ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String GXt_char3 ;
      private String edtavUsu_crt_Jsonclick ;
      private String GXt_char2 ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private String aP0_USU_COD ;
      private IDataStoreProvider pr_default ;
      private String[] H00242_A6USU_COD ;
      private String[] H00242_A7USU_DES ;
      private String[] H00243_A6USU_COD ;
      private String[] H00243_A155USU_CLA ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
   }

   public class hcambio_password__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH00242 ;
          prmH00242 = new Object[] {
          new Object[] {"@USU_COD",SqlDbType.Char,16,0}
          } ;
          Object[] prmH00243 ;
          prmH00243 = new Object[] {
          new Object[] {"@AV15CODIGO",SqlDbType.Char,16,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00242", "SELECT [USU_COD], [USU_DES] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @USU_COD ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00242,1,0,true,true )
             ,new CursorDef("H00243", "SELECT [USU_COD], [USU_CLA] FROM [SEG002] WITH (NOLOCK) WHERE [USU_COD] = @AV15CODIGO ORDER BY [USU_COD] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00243,1,0,false,true )
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
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 50) ;
                break;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 16) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
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
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
