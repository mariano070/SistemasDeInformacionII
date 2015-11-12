/*
               File: HTBUS000
        Description:
             Author: GeneXus C# Generator version 10_1_5-42940
       Generated on: 4/2/2014 19:29:49.0
       Program type: Main program
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
   public class htbus000 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public htbus000( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public htbus000( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( )
      {
         executePrivate();
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
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("mptrazabilidad", "GeneXus.Programs.mptrazabilidad", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
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
         PA162( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START162( ) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("htbus000.aspx") +"\" class=\""+"Form"+"\">") ;
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
            WE162( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT162( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "HTBUS000" ;
      }

      public override String GetPgmdesc( )
      {
         return "" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("htbus000.aspx")  ;
      }

      protected void WB160( )
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
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", "", "false");
            context.WriteHtmlText( "<pre>") ;
            wb_table1_3_162( true) ;
         }
         else
         {
            wb_table1_3_162( false) ;
         }
         return  ;
      }

      protected void wb_table1_3_162e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "<b/>") ;
            context.WriteHtmlText( "</pre>") ;
            wb_table2_81_162( true) ;
         }
         else
         {
            wb_table2_81_162( false) ;
         }
         return  ;
      }

      protected void wb_table2_81_162e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START162( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_5-42940", 0) ;
         Form.Meta.addItem("Description", "", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP160( ) ;
      }

      protected void WS162( )
      {
         START162( ) ;
         EVT162( ) ;
      }

      protected void EVT162( )
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
                              /* Execute user event: E11162 */
                              E11162 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'VER BIENES DE USO'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E12162 */
                              E12162 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'IDENTIFICADORES'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E13162 */
                              E13162 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'ENVíOS PENDIENTES DE RECEPCIóN'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E14162 */
                              E14162 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'MOVIMIENTOS DE BIENES DE USO'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E15162 */
                              E15162 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'BIENES POR POSICIóN O POR RESPONSABLE'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E16162 */
                              E16162 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'BIENES E IDENTIFICADORES'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E17162 */
                              E17162 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'CAMBIO POSICIONES'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E18162 */
                              E18162 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'ADMINISTRACIóN BAJAS BIENES DE USO'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E19162 */
                              E19162 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E20162 */
                              E20162 ();
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

      protected void WE162( )
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

      protected void PA162( )
      {
         if ( nDonePA == 0 )
         {
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void Refresh( )
      {
         RF162( ) ;
         /* End function Refresh */
      }

      protected void RF162( )
      {
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: E20162 */
            E20162 ();
            WB160( ) ;
         }
      }

      protected void STRUP160( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E11162 */
         E11162 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
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
         /* Execute user event: E11162 */
         E11162 ();
         if (returnInSub) return;
      }

      protected void E11162( )
      {
         /* Start Routine */
         tblTable3_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, tblTable3_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(tblTable3_Visible), 5, 0)));
         new loadcontext(context ).execute( out  AV7Context) ;
         AV6USUARIO = AV7Context.gxTpr_User ;
      }

      protected void E12162( )
      {
         /* 'Ver Bienes de Uso' Routine */
         context.wjLoc = formatLink("htbus001_prev.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV8SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV6USUARIO)) ;
      }

      protected void E13162( )
      {
         /* 'Identificadores' Routine */
         context.wjLoc = formatLink("htbus005.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV8SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV6USUARIO)) ;
      }

      protected void E14162( )
      {
         /* 'Envíos Pendientes de Recepción' Routine */
         context.wjLoc = formatLink("htbus011.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV8SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV6USUARIO)) ;
      }

      protected void E15162( )
      {
         /* 'Movimientos de Bienes de Uso' Routine */
         AV9SESION.Set("Pos", "0");
         AV9SESION.Set("Resp", "");
         context.wjLoc = formatLink("htbus013.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV8SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV6USUARIO)) ;
      }

      protected void E16162( )
      {
         /* 'Bienes por Posición o por Responsable' Routine */
         AV9SESION.Set("Pos", "0");
         AV9SESION.Set("Resp", "");
         context.wjLoc = formatLink("htbus014.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV8SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV6USUARIO)) ;
      }

      protected void E17162( )
      {
         /* 'Bienes e Identificadores' Routine */
         AV9SESION.Set("Pos", "0");
         AV9SESION.Set("Resp", "");
         context.wjLoc = formatLink("htbus016.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV8SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV6USUARIO)) ;
      }

      protected void E18162( )
      {
         /* 'Cambio Posiciones' Routine */
         context.wjLoc = formatLink("htbus020.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV8SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV6USUARIO)) ;
      }

      protected void E19162( )
      {
         /* 'Administración Bajas Bienes de Uso' Routine */
         AV9SESION.Set("Inicio", "0");
         context.wjLoc = formatLink("htbus001b.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV8SISTEMA)) + "," + UrlEncode(StringUtil.RTrim(AV6USUARIO)) ;
      }

      protected void nextLoad( )
      {
      }

      protected void E20162( )
      {
         /* Load Routine */
      }

      protected void wb_table2_81_162( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "center", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgImage1_Internalname, "", context.GetImagePath( "f5f8a0c4-001a-440a-877e-a7d6e67aefb3", "", "Modern"), "Modern", 1, 1, "", "", 0, 0, 474, "", 163, "", 0, 0, "", "", 0, "", "", StyleString, ClassString, "", "", "", "", "HLP_HTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_81_162e( true) ;
         }
         else
         {
            wb_table2_81_162e( false) ;
         }
      }

      protected void wb_table1_3_162( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            if ( tblTable3_Visible == 0 )
            {
               sStyleString = sStyleString + "display:none;" ;
            }
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" colspan=\"2\" >") ;
            wb_table3_6_162( true) ;
         }
         else
         {
            wb_table3_6_162( false) ;
         }
         return  ;
      }

      protected void wb_table3_6_162e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td valign=\"top\" >") ;
            /* Embedded Page */
            if ( 1 != 0 )
            {
               context.WriteHtmlText( "<IFRAME src=\""+""+"\"") ;
               context.WriteHtmlText( " name=\""+epContenido_Internalname+"\"") ;
               context.WriteHtmlText( " width=\""+StringUtil.LTrim( StringUtil.Str( (decimal)(700), 4, 0))+"px"+"\"") ;
               context.WriteHtmlText( " height=\""+StringUtil.LTrim( StringUtil.Str( (decimal)(400), 4, 0))+"px"+"\"") ;
               context.WriteHtmlText( " frameborder=\""+StringUtil.LTrim( StringUtil.Str( (decimal)(1), 4, 0))+"\""+" align=\""+"left"+"\""+" title=\""+""+"\""+" scrolling=\""+"auto"+"\""+"></IFRAME>") ;
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_3_162e( true) ;
         }
         else
         {
            wb_table1_3_162e( false) ;
         }
      }

      protected void wb_table3_6_162( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "SubTitle" ;
            StyleString = "font-family:'Verdana'; font-size:9.0pt; font-weight:normal; font-style:normal" ;
            GxWebStd.gx_label_ctrl( context, lblActualizacion_Internalname, 1, 1, 0, "ACTUALIZACION", "", "", "", 0, lblActualizacion_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS000.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgGif_actualizacion_Internalname, "", context.GetImagePath( "f634050c-6662-4cc0-96b9-30ed777c8bd9", "", "Modern"), "Modern", 1, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 7, imgGif_actualizacion_Jsonclick, "'"+""+"'"+",false,"+"'"+"e21162_client"+"'", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_HTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:34px\">") ;
            wb_table4_13_162( true) ;
         }
         else
         {
            wb_table4_13_162( false) ;
         }
         return  ;
      }

      protected void wb_table4_13_162e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:15px\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "SubTitle" ;
            StyleString = "font-family:'Verdana'; font-size:9.0pt; font-weight:normal; font-style:normal" ;
            GxWebStd.gx_label_ctrl( context, lblInformes_Internalname, 1, 1, 0, "INFORMES", "", "", "", 0, lblInformes_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS000.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 32,'',false,'',0)\"" ;
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgGif_informes_Internalname, "", context.GetImagePath( "f634050c-6662-4cc0-96b9-30ed777c8bd9", "", "Modern"), "Modern", 1, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 7, imgGif_informes_Jsonclick, "'"+""+"'"+",false,"+"'"+"e22162_client"+"'", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_HTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table5_35_162( true) ;
         }
         else
         {
            wb_table5_35_162( false) ;
         }
         return  ;
      }

      protected void wb_table5_35_162e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "SubTitle" ;
            StyleString = "font-family:'Verdana'; font-size:9.0pt; font-weight:normal; font-style:normal" ;
            GxWebStd.gx_label_ctrl( context, lblTablas_Internalname, 1, 1, 0, "TABLAS", "", "", "", 0, lblTablas_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS000.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'',0)\"" ;
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgGif_tablas_Internalname, "", context.GetImagePath( "f634050c-6662-4cc0-96b9-30ed777c8bd9", "", "Modern"), "Modern", 1, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 7, imgGif_tablas_Jsonclick, "'"+""+"'"+",false,"+"'"+"e23162_client"+"'", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_HTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table6_54_162( true) ;
         }
         else
         {
            wb_table6_54_162( false) ;
         }
         return  ;
      }

      protected void wb_table6_54_162e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "SubTitle" ;
            StyleString = "font-family:'Verdana'; font-size:9.0pt; font-weight:normal; font-style:normal" ;
            GxWebStd.gx_label_ctrl( context, lblProcesos_Internalname, 1, 1, 0, "PROCESOS", "", "", "", 0, lblProcesos_Jsonclick, "", StyleString, ClassString, "HLP_HTBUS000.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'',0)\"" ;
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgGif_procesos_Internalname, "", context.GetImagePath( "f634050c-6662-4cc0-96b9-30ed777c8bd9", "", "Modern"), "Modern", 1, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, "", "", 7, imgGif_procesos_Jsonclick, "'"+""+"'"+",false,"+"'"+"e24162_client"+"'", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_HTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table7_72_162( true) ;
         }
         else
         {
            wb_table7_72_162( false) ;
         }
         return  ;
      }

      protected void wb_table7_72_162e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_6_162e( true) ;
         }
         else
         {
            wb_table3_6_162e( false) ;
         }
      }

      protected void wb_table7_72_162( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            if ( tblTabla_procesos_Visible == 0 )
            {
               sStyleString = sStyleString + "display:none;" ;
            }
            GxWebStd.gx_table_start( context, tblTabla_procesos_Internalname, tblTabla_procesos_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table7_72_162e( true) ;
         }
         else
         {
            wb_table7_72_162e( false) ;
         }
      }

      protected void wb_table6_54_162( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            if ( tblTabla_tablas_Visible == 0 )
            {
               sStyleString = sStyleString + "display:none;" ;
            }
            GxWebStd.gx_table_start( context, tblTabla_tablas_Internalname, tblTabla_tablas_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, 1, 1, 0, "Identificadores", "", "", "", 5, lblTextblock1_Jsonclick, "E\\'IDENTIFICADORES\\'.", StyleString, ClassString, "HLP_HTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table6_54_162e( true) ;
         }
         else
         {
            wb_table6_54_162e( false) ;
         }
      }

      protected void wb_table5_35_162( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            if ( tblTabla_informes_Visible == 0 )
            {
               sStyleString = sStyleString + "display:none;" ;
            }
            GxWebStd.gx_table_start( context, tblTabla_informes_Internalname, tblTabla_informes_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:15px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, 1, 1, 0, "Envíos Pendientes de Recepción", "", "", "", 5, lblTextblock2_Jsonclick, "E\\'ENVíOS PENDIENTES DE RECEPCIóN\\'.", StyleString, ClassString, "HLP_HTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:15px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock5_Internalname, 1, 1, 0, "Movimientos de Bienes de Uso", "", "", "", 5, lblTextblock5_Jsonclick, "E\\'MOVIMIENTOS DE BIENES DE USO\\'.", StyleString, ClassString, "HLP_HTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock6_Internalname, 1, 1, 0, "Bienes por Posición o por Responsable", "", "", "", 5, lblTextblock6_Jsonclick, "E\\'BIENES POR POSICIóN O POR RESPONSABLE\\'.", StyleString, ClassString, "HLP_HTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock7_Internalname, 1, 1, 0, "Bienes e Identificadores", "", "", "", 5, lblTextblock7_Jsonclick, "E\\'BIENES E IDENTIFICADORES\\'.", StyleString, ClassString, "HLP_HTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_35_162e( true) ;
         }
         else
         {
            wb_table5_35_162e( false) ;
         }
      }

      protected void wb_table4_13_162( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            if ( tblTabla_actualizacion_Visible == 0 )
            {
               sStyleString = sStyleString + "display:none;" ;
            }
            GxWebStd.gx_table_start( context, tblTabla_actualizacion_Internalname, tblTabla_actualizacion_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTxtactualizacion_Internalname, 1, 1, 0, "Actualización de Bienes de Uso", "", "", "", 5, lblTxtactualizacion_Jsonclick, "E\\'VER BIENES DE USO\\'.", StyleString, ClassString, "HLP_HTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock8_Internalname, 1, 1, 0, "Administrador de Cambio de Posiciones", "", "", "", 5, lblTextblock8_Jsonclick, "E\\'CAMBIO POSICIONES\\'.", StyleString, ClassString, "HLP_HTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock9_Internalname, 1, 1, 0, "Administración Bajas Bienes de Uso", "", "", "", 5, lblTextblock9_Jsonclick, "E\\'ADMINISTRACIóN BAJAS BIENES DE USO\\'.", StyleString, ClassString, "HLP_HTBUS000.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_13_162e( true) ;
         }
         else
         {
            wb_table4_13_162e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
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
         PA162( ) ;
         WS162( ) ;
         WE162( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?19294928");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?42940");
         context.AddJavascriptSource("htbus000.js", "?19294928");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblActualizacion_Internalname = "ACTUALIZACION" ;
         imgGif_actualizacion_Internalname = "GIF_ACTUALIZACION" ;
         lblTxtactualizacion_Internalname = "TXTACTUALIZACION" ;
         lblTextblock8_Internalname = "TEXTBLOCK8" ;
         lblTextblock9_Internalname = "TEXTBLOCK9" ;
         tblTabla_actualizacion_Internalname = "TABLA_ACTUALIZACION" ;
         lblInformes_Internalname = "INFORMES" ;
         imgGif_informes_Internalname = "GIF_INFORMES" ;
         lblTextblock2_Internalname = "TEXTBLOCK2" ;
         lblTextblock5_Internalname = "TEXTBLOCK5" ;
         lblTextblock6_Internalname = "TEXTBLOCK6" ;
         lblTextblock7_Internalname = "TEXTBLOCK7" ;
         tblTabla_informes_Internalname = "TABLA_INFORMES" ;
         lblTablas_Internalname = "TABLAS" ;
         imgGif_tablas_Internalname = "GIF_TABLAS" ;
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         tblTabla_tablas_Internalname = "TABLA_TABLAS" ;
         lblProcesos_Internalname = "PROCESOS" ;
         imgGif_procesos_Internalname = "GIF_PROCESOS" ;
         tblTabla_procesos_Internalname = "TABLA_PROCESOS" ;
         tblTable2_Internalname = "TABLE2" ;
         epContenido_Internalname = "Contenido" ;
         tblTable3_Internalname = "TABLE3" ;
         imgImage1_Internalname = "IMAGE1" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         tblTabla_actualizacion_Visible = 1 ;
         tblTabla_informes_Visible = 1 ;
         tblTabla_tablas_Visible = 1 ;
         tblTabla_procesos_Visible = 1 ;
         tblTable3_Visible = 1 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "" ;
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
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         AV7Context = new SdtContext(context);
         AV6USUARIO = "" ;
         AV8SISTEMA = "" ;
         AV9SESION = new GxWebSession( context);
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         lblActualizacion_Jsonclick = "" ;
         TempTags = "" ;
         imgGif_actualizacion_Jsonclick = "" ;
         lblInformes_Jsonclick = "" ;
         imgGif_informes_Jsonclick = "" ;
         lblTablas_Jsonclick = "" ;
         imgGif_tablas_Jsonclick = "" ;
         lblProcesos_Jsonclick = "" ;
         imgGif_procesos_Jsonclick = "" ;
         GXt_char5 = "" ;
         GXt_char4 = "" ;
         lblTextblock1_Jsonclick = "" ;
         lblTextblock2_Jsonclick = "" ;
         lblTextblock5_Jsonclick = "" ;
         lblTextblock6_Jsonclick = "" ;
         lblTextblock7_Jsonclick = "" ;
         lblTxtactualizacion_Jsonclick = "" ;
         lblTextblock8_Jsonclick = "" ;
         lblTextblock9_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
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
      private short nGXWrapped ;
      private int tblTable3_Visible ;
      private int tblTabla_procesos_Visible ;
      private int tblTabla_tablas_Visible ;
      private int tblTabla_informes_Visible ;
      private int tblTabla_actualizacion_Visible ;
      private int idxLst ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String tblTable3_Internalname ;
      private String AV6USUARIO ;
      private String AV8SISTEMA ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String imgImage1_Internalname ;
      private String GXt_char3 ;
      private String epContenido_Internalname ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String tblTable2_Internalname ;
      private String lblActualizacion_Internalname ;
      private String lblActualizacion_Jsonclick ;
      private String TempTags ;
      private String imgGif_actualizacion_Internalname ;
      private String imgGif_actualizacion_Jsonclick ;
      private String lblInformes_Internalname ;
      private String lblInformes_Jsonclick ;
      private String imgGif_informes_Internalname ;
      private String imgGif_informes_Jsonclick ;
      private String lblTablas_Internalname ;
      private String lblTablas_Jsonclick ;
      private String imgGif_tablas_Internalname ;
      private String imgGif_tablas_Jsonclick ;
      private String lblProcesos_Internalname ;
      private String lblProcesos_Jsonclick ;
      private String imgGif_procesos_Internalname ;
      private String imgGif_procesos_Jsonclick ;
      private String GXt_char5 ;
      private String GXt_char4 ;
      private String tblTabla_procesos_Internalname ;
      private String tblTabla_tablas_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String tblTabla_informes_Internalname ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String lblTextblock5_Internalname ;
      private String lblTextblock5_Jsonclick ;
      private String lblTextblock6_Internalname ;
      private String lblTextblock6_Jsonclick ;
      private String lblTextblock7_Internalname ;
      private String lblTextblock7_Jsonclick ;
      private String tblTabla_actualizacion_Internalname ;
      private String lblTxtactualizacion_Internalname ;
      private String lblTxtactualizacion_Jsonclick ;
      private String lblTextblock8_Internalname ;
      private String lblTextblock8_Jsonclick ;
      private String lblTextblock9_Internalname ;
      private String lblTextblock9_Jsonclick ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxWebSession AV9SESION ;
      private GXWebForm Form ;
      private SdtContext AV7Context ;
   }

}
