(function webpackUniversalModuleDefinition(root, factory) {
	if(typeof exports === 'object' && typeof module === 'object')
		module.exports = factory();
	else if(typeof define === 'function' && define.amd)
		define([], factory);
	else if(typeof exports === 'object')
		exports["RelativesTree"] = factory();
	else
		root["RelativesTree"] = factory();
})(this, () => {
return /******/ (() => { // webpackBootstrap
/******/ 	var __webpack_modules__ = ({

/***/ "./lib/children/arrange.js":
/*!*********************************!*\
  !*** ./lib/children/arrange.js ***!
  \*********************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   arrangeFamiliesFunc: () => (/* binding */ arrangeFamiliesFunc)
/* harmony export */ });
/* harmony import */ var _utils_units__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../utils/units */ "./lib/utils/units.js");
/* harmony import */ var _utils_family__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../utils/family */ "./lib/utils/family.js");
/* harmony import */ var _utils__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../utils */ "./lib/utils/index.js");
/* harmony import */ var _utils_arrangeParentsIn__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../utils/arrangeParentsIn */ "./lib/utils/arrangeParentsIn.js");




const arrangeNextFamily = (family, nextFamily, right) => {
    const unit = family.parents[0];
    const index = nextFamily.children.findIndex((0,_utils_units__WEBPACK_IMPORTED_MODULE_0__.sameAs)(unit));
    index === 0
        ? (nextFamily.X = (0,_utils_units__WEBPACK_IMPORTED_MODULE_0__.getUnitX)(family, unit) - nextFamily.children[index].pos)
        : (nextFamily.children[index].pos = (0,_utils_units__WEBPACK_IMPORTED_MODULE_0__.getUnitX)(family, unit) - nextFamily.X);
    const nextIdx = (0,_utils__WEBPACK_IMPORTED_MODULE_2__.nextIndex)(index);
    if (nextFamily.children[nextIdx]) {
        (0,_utils_units__WEBPACK_IMPORTED_MODULE_0__.correctUnitsShift)(nextFamily.children.slice(nextIdx), right - (0,_utils_units__WEBPACK_IMPORTED_MODULE_0__.getUnitX)(nextFamily, nextFamily.children[nextIdx]));
    }
};
const arrangeMiddleFamilies = (families, fid, startFrom) => {
    const start = (0,_utils__WEBPACK_IMPORTED_MODULE_2__.nextIndex)(families.findIndex((0,_utils__WEBPACK_IMPORTED_MODULE_2__.withId)(fid)));
    const family = families[start];
    if (family) {
        const shift = startFrom - family.X;
        for (let i = start; i < families.length; i++)
            families[i].X += shift;
    }
};
const arrangeFamiliesFunc = (store) => (family) => {
    let right = 0;
    while (family.pid) {
        right = Math.max(right, (0,_utils_family__WEBPACK_IMPORTED_MODULE_1__.rightOf)(family));
        const nextFamily = store.getFamily(family.pid);
        arrangeNextFamily(family, nextFamily, right);
        (0,_utils_arrangeParentsIn__WEBPACK_IMPORTED_MODULE_3__.arrangeParentsIn)(nextFamily);
        if (!nextFamily.pid)
            arrangeMiddleFamilies(store.rootFamilies, nextFamily.id, Math.max(right, (0,_utils_family__WEBPACK_IMPORTED_MODULE_1__.rightOf)(nextFamily)));
        family = nextFamily;
    }
};


/***/ }),

/***/ "./lib/children/create.js":
/*!********************************!*\
  !*** ./lib/children/create.js ***!
  \********************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   createFamilyFunc: () => (/* binding */ createFamilyFunc)
/* harmony export */ });
/* harmony import */ var _utils__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../utils */ "./lib/utils/index.js");
/* harmony import */ var _utils_units__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../utils/units */ "./lib/utils/units.js");
/* harmony import */ var _utils_family__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../utils/family */ "./lib/utils/family.js");
/* harmony import */ var _utils_setDefaultUnitShift__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../utils/setDefaultUnitShift */ "./lib/utils/setDefaultUnitShift.js");
/* harmony import */ var _utils_createChildUnitsFunc__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../utils/createChildUnitsFunc */ "./lib/utils/createChildUnitsFunc.js");
/* harmony import */ var _types__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ../types */ "./lib/types.js");






const hasSameRelation = (node) => (rel) => !node || node.children.some((0,_utils__WEBPACK_IMPORTED_MODULE_0__.withId)(rel.id));
const getChildUnitsFunc = (store) => {
    const toNode = (0,_utils__WEBPACK_IMPORTED_MODULE_0__.relToNode)(store);
    const createChildUnits = (0,_utils_createChildUnitsFunc__WEBPACK_IMPORTED_MODULE_4__.createChildUnitsFunc)(store);
    return (familyId, parents) => {
        const [first, second] = parents;
        return first.children
            .filter(hasSameRelation(second))
            .flatMap((rel) => createChildUnits(familyId, toNode(rel)));
    };
};
const createFamilyFunc = (store) => {
    const getChildUnits = getChildUnitsFunc(store);
    return (parentIDs, type = _types__WEBPACK_IMPORTED_MODULE_5__.FamilyType.root, isMain = false) => {
        const family = (0,_utils_family__WEBPACK_IMPORTED_MODULE_2__.newFamily)(store.getNextId(), type, isMain);
        const parents = parentIDs
            .map((id) => store.getNode(id))
            .sort((0,_utils__WEBPACK_IMPORTED_MODULE_0__.byGender)(store.root.gender));
        family.parents = [(0,_utils_units__WEBPACK_IMPORTED_MODULE_1__.newUnit)(family.id, parents)];
        family.children = getChildUnits(family.id, parents);
        (0,_utils_setDefaultUnitShift__WEBPACK_IMPORTED_MODULE_3__.setDefaultUnitShift)(family);
        return family;
    };
};


/***/ }),

/***/ "./lib/children/index.js":
/*!*******************************!*\
  !*** ./lib/children/index.js ***!
  \*******************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   inChildDirection: () => (/* binding */ inChildDirection)
/* harmony export */ });
/* harmony import */ var _utils_family__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../utils/family */ "./lib/utils/family.js");
/* harmony import */ var _utils_units__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../utils/units */ "./lib/utils/units.js");
/* harmony import */ var _types__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../types */ "./lib/types.js");
/* harmony import */ var _create__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./create */ "./lib/children/create.js");
/* harmony import */ var _update__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./update */ "./lib/children/update.js");
/* harmony import */ var _arrange__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./arrange */ "./lib/children/arrange.js");






const getUnitsWithChildren = (family) => family.children.filter(_utils_units__WEBPACK_IMPORTED_MODULE_1__.hasChildren).reverse();
const inChildDirection = (store) => {
    const createFamily = (0,_create__WEBPACK_IMPORTED_MODULE_3__.createFamilyFunc)(store);
    const updateFamily = (0,_update__WEBPACK_IMPORTED_MODULE_4__.updateFamilyFunc)(store);
    const arrangeFamilies = (0,_arrange__WEBPACK_IMPORTED_MODULE_5__.arrangeFamiliesFunc)(store);
    store.familiesArray.filter((0,_utils_family__WEBPACK_IMPORTED_MODULE_0__.withType)(_types__WEBPACK_IMPORTED_MODULE_2__.FamilyType.root)).forEach((rootFamily) => {
        let stack = getUnitsWithChildren(rootFamily);
        while (stack.length) {
            const parentUnit = stack.pop();
            const family = createFamily((0,_utils_units__WEBPACK_IMPORTED_MODULE_1__.nodeIds)(parentUnit), _types__WEBPACK_IMPORTED_MODULE_2__.FamilyType.child);
            updateFamily(family, parentUnit);
            arrangeFamilies(family);
            store.families.set(family.id, family);
            stack = stack.concat(getUnitsWithChildren(family));
        }
    });
    return store;
};


/***/ }),

/***/ "./lib/children/update.js":
/*!********************************!*\
  !*** ./lib/children/update.js ***!
  \********************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   updateFamilyFunc: () => (/* binding */ updateFamilyFunc)
/* harmony export */ });
/* harmony import */ var _constants__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../constants */ "./lib/constants.js");
/* harmony import */ var _utils_family__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../utils/family */ "./lib/utils/family.js");
/* harmony import */ var _utils_units__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../utils/units */ "./lib/utils/units.js");



const updateFamilyFunc = (store) => (family, parentUnit) => {
    const parentFamily = store.getFamily(parentUnit.fid);
    family.pid = parentFamily.id;
    family.Y = parentFamily.Y + (0,_utils_family__WEBPACK_IMPORTED_MODULE_1__.heightOf)(parentFamily) - _constants__WEBPACK_IMPORTED_MODULE_0__.SIZE;
    family.X = (0,_utils_units__WEBPACK_IMPORTED_MODULE_2__.getUnitX)(parentFamily, parentUnit);
};


/***/ }),

/***/ "./lib/connectors/children.js":
/*!************************************!*\
  !*** ./lib/connectors/children.js ***!
  \************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   children: () => (/* binding */ children)
/* harmony export */ });
/* harmony import */ var _utils_family__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../utils/family */ "./lib/utils/family.js");
/* harmony import */ var _utils_units__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../utils/units */ "./lib/utils/units.js");
/* harmony import */ var _utils__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../utils */ "./lib/utils/index.js");
/* harmony import */ var _constants__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../constants */ "./lib/constants.js");
/* harmony import */ var _types__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../types */ "./lib/types.js");





const children = (families) => families
    .filter((0,_utils_family__WEBPACK_IMPORTED_MODULE_0__.withType)(_types__WEBPACK_IMPORTED_MODULE_4__.FamilyType.root, _types__WEBPACK_IMPORTED_MODULE_4__.FamilyType.child))
    .reduce((connectors, family) => {
    const parent = family.parents[0];
    const pX = (0,_utils_family__WEBPACK_IMPORTED_MODULE_0__.getParentsX)(family, parent);
    const mY = family.Y + (parent ? _constants__WEBPACK_IMPORTED_MODULE_3__.SIZE : 0);
    if (parent && parent.nodes.every((node) => !!node.children.length)) {
        const pY = family.Y + _constants__WEBPACK_IMPORTED_MODULE_3__.HALF_SIZE;
        connectors.push([pX, pY, pX, mY]);
    }
    const parentIds = family.parents.map(_utils_units__WEBPACK_IMPORTED_MODULE_1__.nodeIds).flat();
    const positions = [];
    family.children.forEach((unit) => {
        const left = (0,_utils_units__WEBPACK_IMPORTED_MODULE_1__.getUnitX)(family, unit) + _constants__WEBPACK_IMPORTED_MODULE_3__.HALF_SIZE;
        unit.nodes.forEach((node, index) => {
            if (node.parents.some((0,_utils__WEBPACK_IMPORTED_MODULE_2__.withIds)(parentIds))) {
                const nX = left + index * _constants__WEBPACK_IMPORTED_MODULE_3__.SIZE;
                positions.push(nX);
                connectors.push([nX, mY, nX, mY + _constants__WEBPACK_IMPORTED_MODULE_3__.HALF_SIZE]);
            }
        });
        if ((0,_utils_units__WEBPACK_IMPORTED_MODULE_1__.nodeCount)(unit) === _constants__WEBPACK_IMPORTED_MODULE_3__.NODES_IN_COUPLE) {
            connectors.push([left, mY + _constants__WEBPACK_IMPORTED_MODULE_3__.HALF_SIZE, left + _constants__WEBPACK_IMPORTED_MODULE_3__.SIZE, mY + _constants__WEBPACK_IMPORTED_MODULE_3__.HALF_SIZE]);
        }
        else if ((0,_utils_units__WEBPACK_IMPORTED_MODULE_1__.nodeCount)(unit) === 1 && unit.nodes[0].spouses.length) {
            family.children.forEach((nUnit) => {
                if (nUnit.nodes.some((0,_utils__WEBPACK_IMPORTED_MODULE_2__.withId)(unit.nodes[0].spouses[0].id))) {
                    const xX = [left, (0,_utils_units__WEBPACK_IMPORTED_MODULE_1__.getUnitX)(family, nUnit) + _constants__WEBPACK_IMPORTED_MODULE_3__.HALF_SIZE].sort(_utils__WEBPACK_IMPORTED_MODULE_2__.inAscOrder);
                    connectors.push([xX[0], mY + _constants__WEBPACK_IMPORTED_MODULE_3__.HALF_SIZE, xX[1], mY + _constants__WEBPACK_IMPORTED_MODULE_3__.HALF_SIZE]);
                }
            });
        }
    });
    if (positions.length > 1)
        connectors.push([(0,_utils__WEBPACK_IMPORTED_MODULE_2__.min)(positions), mY, (0,_utils__WEBPACK_IMPORTED_MODULE_2__.max)(positions), mY]);
    else if (positions.length === 1 && pX !== positions[0])
        connectors.push([Math.min(pX, positions[0]), mY, Math.max(pX, positions[0]), mY]);
    return connectors;
}, []);


/***/ }),

/***/ "./lib/connectors/index.js":
/*!*********************************!*\
  !*** ./lib/connectors/index.js ***!
  \*********************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   connectors: () => (/* binding */ connectors)
/* harmony export */ });
/* harmony import */ var _parents__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./parents */ "./lib/connectors/parents.js");
/* harmony import */ var _middle__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./middle */ "./lib/connectors/middle.js");
/* harmony import */ var _children__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./children */ "./lib/connectors/children.js");



const toConnectors = (families) => (fn) => fn(families);
const connectors = (families) => [_parents__WEBPACK_IMPORTED_MODULE_0__.parents, _middle__WEBPACK_IMPORTED_MODULE_1__.middle, _children__WEBPACK_IMPORTED_MODULE_2__.children].map(toConnectors(families)).flat();


/***/ }),

/***/ "./lib/connectors/middle.js":
/*!**********************************!*\
  !*** ./lib/connectors/middle.js ***!
  \**********************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   middle: () => (/* binding */ middle)
/* harmony export */ });
/* harmony import */ var _utils__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../utils */ "./lib/utils/index.js");
/* harmony import */ var _utils_units__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../utils/units */ "./lib/utils/units.js");
/* harmony import */ var _utils_family__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../utils/family */ "./lib/utils/family.js");
/* harmony import */ var _constants__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../constants */ "./lib/constants.js");
/* harmony import */ var _types__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../types */ "./lib/types.js");





const calcConnectors = (family, families) => (connectors, unit) => {
    const pX = (0,_utils_units__WEBPACK_IMPORTED_MODULE_1__.getUnitX)(family, unit) + _constants__WEBPACK_IMPORTED_MODULE_3__.HALF_SIZE;
    const pY = family.Y + _constants__WEBPACK_IMPORTED_MODULE_3__.HALF_SIZE;
    if ((0,_utils_units__WEBPACK_IMPORTED_MODULE_1__.nodeCount)(unit) === _constants__WEBPACK_IMPORTED_MODULE_3__.NODES_IN_COUPLE) {
        connectors.push([pX, pY, pX + _constants__WEBPACK_IMPORTED_MODULE_3__.SIZE, pY]);
    }
    else if ((0,_utils_units__WEBPACK_IMPORTED_MODULE_1__.nodeCount)(unit) === 1 && unit.nodes[0].spouses.length) {
        families
            .filter((item) => item.id !== family.id)
            .forEach((other) => {
            other.parents.forEach((parent) => {
                if (parent.nodes.some((0,_utils__WEBPACK_IMPORTED_MODULE_0__.withId)(unit.nodes[0].spouses[0].id))) {
                    const xX = [pX, (0,_utils_units__WEBPACK_IMPORTED_MODULE_1__.getUnitX)(other, parent) + _constants__WEBPACK_IMPORTED_MODULE_3__.HALF_SIZE].sort(_utils__WEBPACK_IMPORTED_MODULE_0__.inAscOrder);
                    connectors.push([xX[0], pY, xX[1], pY]);
                }
            });
        });
    }
    return connectors;
};
const middle = (families) => {
    const rootFamilies = families.filter((0,_utils_family__WEBPACK_IMPORTED_MODULE_2__.withType)(_types__WEBPACK_IMPORTED_MODULE_4__.FamilyType.root));
    return rootFamilies.reduce((connectors, family) => connectors.concat(family.parents.reduce(calcConnectors(family, rootFamilies), [])), []);
};


/***/ }),

/***/ "./lib/connectors/parents.js":
/*!***********************************!*\
  !*** ./lib/connectors/parents.js ***!
  \***********************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   parents: () => (/* binding */ parents)
/* harmony export */ });
/* harmony import */ var _utils__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../utils */ "./lib/utils/index.js");
/* harmony import */ var _utils_units__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../utils/units */ "./lib/utils/units.js");
/* harmony import */ var _utils_family__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../utils/family */ "./lib/utils/family.js");
/* harmony import */ var _constants__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../constants */ "./lib/constants.js");
/* harmony import */ var _types__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../types */ "./lib/types.js");





const getChildIDs = (unit) => unit.nodes.map((0,_utils__WEBPACK_IMPORTED_MODULE_0__.prop)('children')).flat().map((0,_utils__WEBPACK_IMPORTED_MODULE_0__.prop)('id'));
const calcConnectors = (family) => (connectors, unit) => {
    const pX = (0,_utils_family__WEBPACK_IMPORTED_MODULE_2__.getParentsX)(family, unit);
    const pY = family.Y + _constants__WEBPACK_IMPORTED_MODULE_3__.HALF_SIZE;
    const mY = family.Y + _constants__WEBPACK_IMPORTED_MODULE_3__.SIZE;
    if ((0,_utils_units__WEBPACK_IMPORTED_MODULE_1__.nodeCount)(unit) === _constants__WEBPACK_IMPORTED_MODULE_3__.NODES_IN_COUPLE)
        connectors.push([pX - _constants__WEBPACK_IMPORTED_MODULE_3__.HALF_SIZE, pY, pX + _constants__WEBPACK_IMPORTED_MODULE_3__.HALF_SIZE, pY]);
    connectors.push([pX, pY, pX, mY]);
    const child = family.children[0];
    const cX = (0,_utils_units__WEBPACK_IMPORTED_MODULE_1__.getUnitX)(family, child) + child.nodes.findIndex((0,_utils__WEBPACK_IMPORTED_MODULE_0__.withIds)(getChildIDs(unit))) * _constants__WEBPACK_IMPORTED_MODULE_3__.SIZE + _constants__WEBPACK_IMPORTED_MODULE_3__.HALF_SIZE;
    connectors.push([cX, mY, cX, mY + _constants__WEBPACK_IMPORTED_MODULE_3__.HALF_SIZE]);
    if (pX !== cX)
        connectors.push([Math.min(pX, cX), mY, Math.max(pX, cX), mY]);
    return connectors;
};
const parents = (families) => families.filter((0,_utils_family__WEBPACK_IMPORTED_MODULE_2__.withType)(_types__WEBPACK_IMPORTED_MODULE_4__.FamilyType.parent)).reduce((connectors, family) => {
    return connectors.concat(family.parents.reduce(calcConnectors(family), []));
}, []);


/***/ }),

/***/ "./lib/constants.js":
/*!**************************!*\
  !*** ./lib/constants.js ***!
  \**************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   HALF_SIZE: () => (/* binding */ HALF_SIZE),
/* harmony export */   NODES_IN_COUPLE: () => (/* binding */ NODES_IN_COUPLE),
/* harmony export */   SIZE: () => (/* binding */ SIZE)
/* harmony export */ });
const SIZE = 2;
const HALF_SIZE = SIZE / 2;
const NODES_IN_COUPLE = 2;


/***/ }),

/***/ "./lib/index.js":
/*!**********************!*\
  !*** ./lib/index.js ***!
  \**********************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "default": () => (__WEBPACK_DEFAULT_EXPORT__)
/* harmony export */ });
/* harmony import */ var _store__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./store */ "./lib/store.js");
/* harmony import */ var _middle_placeholders__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./middle/placeholders */ "./lib/middle/placeholders.js");
/* harmony import */ var _middle__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./middle */ "./lib/middle/index.js");
/* harmony import */ var _parents__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./parents */ "./lib/parents/index.js");
/* harmony import */ var _children__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ./children */ "./lib/children/index.js");
/* harmony import */ var _connectors__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ./connectors */ "./lib/connectors/index.js");
/* harmony import */ var _utils_correctPositions__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ./utils/correctPositions */ "./lib/utils/correctPositions.js");
/* harmony import */ var _utils_getCanvasSize__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ./utils/getCanvasSize */ "./lib/utils/getCanvasSize.js");
/* harmony import */ var _utils_getExtendedNodes__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ./utils/getExtendedNodes */ "./lib/utils/getExtendedNodes.js");
/* harmony import */ var _utils__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! ./utils */ "./lib/utils/index.js");










const calcFamilies = (0,_utils__WEBPACK_IMPORTED_MODULE_9__.pipe)(_middle__WEBPACK_IMPORTED_MODULE_2__.inMiddleDirection, _parents__WEBPACK_IMPORTED_MODULE_3__.inParentDirection, _children__WEBPACK_IMPORTED_MODULE_4__.inChildDirection, _utils_correctPositions__WEBPACK_IMPORTED_MODULE_6__.correctPositions);
/* harmony default export */ const __WEBPACK_DEFAULT_EXPORT__ = ((nodes, options) => {
    const store = new _store__WEBPACK_IMPORTED_MODULE_0__["default"](nodes, options.rootId);
    if (options.placeholders)
        (0,_middle_placeholders__WEBPACK_IMPORTED_MODULE_1__.placeholders)(store);
    const families = calcFamilies(store).familiesArray;
    return {
        families: families,
        canvas: (0,_utils_getCanvasSize__WEBPACK_IMPORTED_MODULE_7__.getCanvasSize)(families),
        nodes: (0,_utils_getExtendedNodes__WEBPACK_IMPORTED_MODULE_8__.getExtendedNodes)(families),
        connectors: (0,_connectors__WEBPACK_IMPORTED_MODULE_5__.connectors)(families),
    };
});


/***/ }),

/***/ "./lib/middle/correctOverlaps.js":
/*!***************************************!*\
  !*** ./lib/middle/correctOverlaps.js ***!
  \***************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   correctOverlaps: () => (/* binding */ correctOverlaps)
/* harmony export */ });
/* harmony import */ var _utils__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../utils */ "./lib/utils/index.js");
/* harmony import */ var _utils_units__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../utils/units */ "./lib/utils/units.js");
/* harmony import */ var _utils_setDefaultUnitShift__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../utils/setDefaultUnitShift */ "./lib/utils/setDefaultUnitShift.js");



const moveSharedUnitToRight = (sharedIDs) => (a, b) => {
    const foundA = a.nodes.some((0,_utils__WEBPACK_IMPORTED_MODULE_0__.withIds)(sharedIDs));
    const foundB = b.nodes.some((0,_utils__WEBPACK_IMPORTED_MODULE_0__.withIds)(sharedIDs));
    if (foundA && !foundB)
        return 1;
    if (!foundA && foundB)
        return -1;
    return 0;
};
const sameIn = (units) => {
    const target = (0,_utils_units__WEBPACK_IMPORTED_MODULE_1__.unitsToNodes)(units);
    return (node) => target.some((0,_utils__WEBPACK_IMPORTED_MODULE_0__.withId)(node.id));
};
const correctOverlaps = (bloodFamily, adoptedFamily) => {
    const sharedIDs = (0,_utils_units__WEBPACK_IMPORTED_MODULE_1__.unitsToNodes)(bloodFamily.children)
        .filter(sameIn(adoptedFamily.children))
        .map((0,_utils__WEBPACK_IMPORTED_MODULE_0__.prop)('id'));
    const cachePos = bloodFamily.children.map((0,_utils__WEBPACK_IMPORTED_MODULE_0__.prop)('pos'));
    bloodFamily.children = [...bloodFamily.children].sort(moveSharedUnitToRight(sharedIDs));
    bloodFamily.children.forEach((unit, idx) => (unit.pos = cachePos[idx]));
    adoptedFamily.children = adoptedFamily.children.filter((unit) => unit.nodes.some((0,_utils__WEBPACK_IMPORTED_MODULE_0__.withIds)(sharedIDs, false)));
    (0,_utils_setDefaultUnitShift__WEBPACK_IMPORTED_MODULE_2__.setDefaultUnitShift)(adoptedFamily);
};


/***/ }),

/***/ "./lib/middle/create.js":
/*!******************************!*\
  !*** ./lib/middle/create.js ***!
  \******************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   createBloodFamilies: () => (/* binding */ createBloodFamilies),
/* harmony export */   createDiffTypeFamilies: () => (/* binding */ createDiffTypeFamilies),
/* harmony export */   createFamilyWithoutParents: () => (/* binding */ createFamilyWithoutParents)
/* harmony export */ });
/* harmony import */ var _utils_createChildUnitsFunc__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../utils/createChildUnitsFunc */ "./lib/utils/createChildUnitsFunc.js");
/* harmony import */ var _children_create__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../children/create */ "./lib/children/create.js");
/* harmony import */ var _utils_getSpouseNodesFunc__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../utils/getSpouseNodesFunc */ "./lib/utils/getSpouseNodesFunc.js");
/* harmony import */ var _utils_setDefaultUnitShift__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../utils/setDefaultUnitShift */ "./lib/utils/setDefaultUnitShift.js");
/* harmony import */ var _utils__WEBPACK_IMPORTED_MODULE_4__ = __webpack_require__(/*! ../utils */ "./lib/utils/index.js");
/* harmony import */ var _utils_family__WEBPACK_IMPORTED_MODULE_5__ = __webpack_require__(/*! ../utils/family */ "./lib/utils/family.js");
/* harmony import */ var _utils_units__WEBPACK_IMPORTED_MODULE_6__ = __webpack_require__(/*! ../utils/units */ "./lib/utils/units.js");
/* harmony import */ var _constants__WEBPACK_IMPORTED_MODULE_7__ = __webpack_require__(/*! ../constants */ "./lib/constants.js");
/* harmony import */ var _types__WEBPACK_IMPORTED_MODULE_8__ = __webpack_require__(/*! ../types */ "./lib/types.js");
/* harmony import */ var _correctOverlaps__WEBPACK_IMPORTED_MODULE_9__ = __webpack_require__(/*! ./correctOverlaps */ "./lib/middle/correctOverlaps.js");










const createFamilyWithoutParents = (store) => {
    const family = (0,_utils_family__WEBPACK_IMPORTED_MODULE_5__.newFamily)(store.getNextId(), _types__WEBPACK_IMPORTED_MODULE_8__.FamilyType.root, true);
    family.children = (0,_utils_createChildUnitsFunc__WEBPACK_IMPORTED_MODULE_0__.createChildUnitsFunc)(store)(family.id, store.root);
    (0,_utils_setDefaultUnitShift__WEBPACK_IMPORTED_MODULE_3__.setDefaultUnitShift)(family);
    return [family];
};
const getParentIDs = (root, type) => root.parents.filter((0,_utils__WEBPACK_IMPORTED_MODULE_4__.withRelType)(type)).map((0,_utils__WEBPACK_IMPORTED_MODULE_4__.prop)('id'));
const createDiffTypeFamilies = (store) => {
    const createFamily = (0,_children_create__WEBPACK_IMPORTED_MODULE_1__.createFamilyFunc)(store);
    const bloodFamily = createFamily(getParentIDs(store.root, _types__WEBPACK_IMPORTED_MODULE_8__.RelType.blood), _types__WEBPACK_IMPORTED_MODULE_8__.FamilyType.root, true);
    const adoptedFamily = createFamily(getParentIDs(store.root, _types__WEBPACK_IMPORTED_MODULE_8__.RelType.adopted));
    (0,_correctOverlaps__WEBPACK_IMPORTED_MODULE_9__.correctOverlaps)(bloodFamily, adoptedFamily);
    return [bloodFamily, adoptedFamily];
};
const createBloodFamilies = (store) => {
    const createFamily = (0,_children_create__WEBPACK_IMPORTED_MODULE_1__.createFamilyFunc)(store);
    const mainFamily = createFamily(store.root.parents.map((0,_utils__WEBPACK_IMPORTED_MODULE_4__.prop)('id')), _types__WEBPACK_IMPORTED_MODULE_8__.FamilyType.root, true);
    const parents = (0,_utils_units__WEBPACK_IMPORTED_MODULE_6__.unitsToNodes)(mainFamily.parents);
    if (parents.length === _constants__WEBPACK_IMPORTED_MODULE_7__.NODES_IN_COUPLE) {
        const { left, right } = (0,_utils_getSpouseNodesFunc__WEBPACK_IMPORTED_MODULE_2__.getSpouseNodesFunc)(store)(parents);
        return [
            left.map((node) => createFamily([node.id])),
            mainFamily,
            right.map((node) => createFamily([node.id])),
        ].flat();
    }
    return [mainFamily];
};


/***/ }),

/***/ "./lib/middle/index.js":
/*!*****************************!*\
  !*** ./lib/middle/index.js ***!
  \*****************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   inMiddleDirection: () => (/* binding */ inMiddleDirection)
/* harmony export */ });
/* harmony import */ var _utils__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../utils */ "./lib/utils/index.js");
/* harmony import */ var _utils_family__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../utils/family */ "./lib/utils/family.js");
/* harmony import */ var _create__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./create */ "./lib/middle/create.js");



const arrangeFamilies = (families) => {
    for (let i = 1; i < families.length; i++) {
        families[i].X = (0,_utils_family__WEBPACK_IMPORTED_MODULE_1__.rightOf)(families[i - 1]);
    }
};
const inMiddleDirection = (store) => {
    const families = store.root.parents.length
        ? (0,_utils__WEBPACK_IMPORTED_MODULE_0__.hasDiffParents)(store.root)
            ? (0,_create__WEBPACK_IMPORTED_MODULE_2__.createDiffTypeFamilies)(store)
            : (0,_create__WEBPACK_IMPORTED_MODULE_2__.createBloodFamilies)(store)
        : (0,_create__WEBPACK_IMPORTED_MODULE_2__.createFamilyWithoutParents)(store);
    arrangeFamilies(families);
    families.forEach((family) => store.families.set(family.id, family));
    return store;
};


/***/ }),

/***/ "./lib/middle/placeholders.js":
/*!************************************!*\
  !*** ./lib/middle/placeholders.js ***!
  \************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   placeholders: () => (/* binding */ placeholders)
/* harmony export */ });
/* harmony import */ var _types__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../types */ "./lib/types.js");
/* harmony import */ var _utils__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../utils */ "./lib/utils/index.js");


const createRel = (id, type = _types__WEBPACK_IMPORTED_MODULE_0__.RelType.blood) => ({ id, type });
const createNode = (gender) => ({
    id: `${gender}-ph`,
    placeholder: true,
    gender: gender,
    parents: [],
    siblings: [],
    spouses: [],
    children: [],
});
const createParents = (store) => {
    const father = createNode(_types__WEBPACK_IMPORTED_MODULE_0__.Gender.male);
    const mother = createNode(_types__WEBPACK_IMPORTED_MODULE_0__.Gender.female);
    father.spouses = [createRel(mother.id, _types__WEBPACK_IMPORTED_MODULE_0__.RelType.married)];
    mother.spouses = [createRel(father.id, _types__WEBPACK_IMPORTED_MODULE_0__.RelType.married)];
    return [father, mother].map((node) => {
        node.children = store.root.siblings.concat(createRel(store.root.id));
        store.nodes.set(node.id, node);
        return createRel(node.id);
    });
};
const setParents = (parents) => (node) => (node.parents = parents.slice());
const placeholders = (store) => {
    if (!store.root.parents.length) {
        const setParentsTo = setParents(createParents(store));
        setParentsTo(store.root);
        store.root.siblings.map((0,_utils__WEBPACK_IMPORTED_MODULE_1__.relToNode)(store)).forEach(setParentsTo);
    }
    return store;
};


/***/ }),

/***/ "./lib/parents/arrange.js":
/*!********************************!*\
  !*** ./lib/parents/arrange.js ***!
  \********************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   arrangeFamiliesFunc: () => (/* binding */ arrangeFamiliesFunc)
/* harmony export */ });
/* harmony import */ var _constants__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../constants */ "./lib/constants.js");
/* harmony import */ var _utils_units__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../utils/units */ "./lib/utils/units.js");
/* harmony import */ var _utils_family__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../utils/family */ "./lib/utils/family.js");
/* harmony import */ var _utils__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../utils */ "./lib/utils/index.js");




const arrangeNextFamily = (family, nextFamily, right) => {
    const unit = family.children[0];
    const index = nextFamily.parents.findIndex((0,_utils_units__WEBPACK_IMPORTED_MODULE_1__.sameAs)(unit));
    index === 0 && nextFamily.parents[index].pos === 0
        ? (nextFamily.X = (0,_utils_units__WEBPACK_IMPORTED_MODULE_1__.getUnitX)(family, unit))
        : (nextFamily.parents[index].pos = (0,_utils_units__WEBPACK_IMPORTED_MODULE_1__.getUnitX)(family, unit) - nextFamily.X);
    const nextIdx = (0,_utils__WEBPACK_IMPORTED_MODULE_3__.nextIndex)(index);
    if (nextFamily.parents[nextIdx]) {
        (0,_utils_units__WEBPACK_IMPORTED_MODULE_1__.correctUnitsShift)(nextFamily.parents.slice(nextIdx), right - (0,_utils_units__WEBPACK_IMPORTED_MODULE_1__.getUnitX)(nextFamily, nextFamily.parents[nextIdx]));
    }
};
const arrangeFamiliesFunc = (store) => (family) => {
    let right = 0;
    while (family.cid) {
        right = Math.max(right, (0,_utils_family__WEBPACK_IMPORTED_MODULE_2__.rightOf)(family));
        const nextFamily = store.getFamily(family.cid);
        const unit = family.children[0];
        if (!nextFamily.cid) {
            unit.pos = ((0,_utils_family__WEBPACK_IMPORTED_MODULE_2__.widthOf)(family) - (0,_utils_units__WEBPACK_IMPORTED_MODULE_1__.nodeCount)(unit) * _constants__WEBPACK_IMPORTED_MODULE_0__.SIZE) / 2;
        }
        else {
            if (family.parents.length === 2 && (0,_utils_family__WEBPACK_IMPORTED_MODULE_2__.unitNodesCount)(family.parents) > 2)
                unit.pos = Math.floor(family.parents[1].pos / 2);
            arrangeNextFamily(family, nextFamily, right);
        }
        family = nextFamily;
    }
};


/***/ }),

/***/ "./lib/parents/create.js":
/*!*******************************!*\
  !*** ./lib/parents/create.js ***!
  \*******************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   createFamilyFunc: () => (/* binding */ createFamilyFunc)
/* harmony export */ });
/* harmony import */ var _utils__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../utils */ "./lib/utils/index.js");
/* harmony import */ var _utils_units__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../utils/units */ "./lib/utils/units.js");
/* harmony import */ var _utils_family__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../utils/family */ "./lib/utils/family.js");
/* harmony import */ var _types__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../types */ "./lib/types.js");




const getParentUnits = (store, unit) => unit.nodes.reduce((units, child) => {
    const parents = store.getNodes(child.parents.map((0,_utils__WEBPACK_IMPORTED_MODULE_0__.prop)('id'))).sort((0,_utils__WEBPACK_IMPORTED_MODULE_0__.byGender)(store.root.gender));
    if (parents.length)
        units.push((0,_utils_units__WEBPACK_IMPORTED_MODULE_1__.newUnit)(unit.fid, parents));
    return units;
}, []);
const setDefaultUnitShift = (family) => {
    (0,_utils_units__WEBPACK_IMPORTED_MODULE_1__.arrangeInOrder)(family.children);
    (0,_utils_units__WEBPACK_IMPORTED_MODULE_1__.arrangeInOrder)(family.parents);
};
const createFamilyFunc = (store) => {
    return (childIDs) => {
        const family = (0,_utils_family__WEBPACK_IMPORTED_MODULE_2__.newFamily)(store.getNextId(), _types__WEBPACK_IMPORTED_MODULE_3__.FamilyType.parent);
        const childUnit = (0,_utils_units__WEBPACK_IMPORTED_MODULE_1__.newUnit)(family.id, store.getNodes(childIDs), true);
        family.children = [childUnit];
        family.parents = getParentUnits(store, childUnit);
        setDefaultUnitShift(family);
        return family;
    };
};


/***/ }),

/***/ "./lib/parents/index.js":
/*!******************************!*\
  !*** ./lib/parents/index.js ***!
  \******************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   inParentDirection: () => (/* binding */ inParentDirection)
/* harmony export */ });
/* harmony import */ var _utils_units__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../utils/units */ "./lib/utils/units.js");
/* harmony import */ var _create__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./create */ "./lib/parents/create.js");
/* harmony import */ var _update__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./update */ "./lib/parents/update.js");
/* harmony import */ var _arrange__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./arrange */ "./lib/parents/arrange.js");




const getParentUnitsWithParents = (family) => family.parents.filter((unit) => unit.nodes.some((node) => !!node.parents.length));
const inParentDirection = (store) => {
    const createFamily = (0,_create__WEBPACK_IMPORTED_MODULE_1__.createFamilyFunc)(store);
    const updateFamily = (0,_update__WEBPACK_IMPORTED_MODULE_2__.updateFamilyFunc)(store);
    const arrangeFamily = (0,_arrange__WEBPACK_IMPORTED_MODULE_3__.arrangeFamiliesFunc)(store);
    let stack = getParentUnitsWithParents(store.rootFamily);
    while (stack.length) {
        const childUnit = stack.pop();
        const family = createFamily((0,_utils_units__WEBPACK_IMPORTED_MODULE_0__.nodeIds)(childUnit));
        updateFamily(family, childUnit);
        arrangeFamily(family);
        store.families.set(family.id, family);
        stack = stack.concat(getParentUnitsWithParents(family).reverse());
    }
    return store;
};


/***/ }),

/***/ "./lib/parents/update.js":
/*!*******************************!*\
  !*** ./lib/parents/update.js ***!
  \*******************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   updateFamilyFunc: () => (/* binding */ updateFamilyFunc)
/* harmony export */ });
/* harmony import */ var _constants__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../constants */ "./lib/constants.js");
/* harmony import */ var _utils_units__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../utils/units */ "./lib/utils/units.js");


const updateFamilyFunc = (store) => (family, childUnit) => {
    const childFamily = store.getFamily(childUnit.fid);
    family.cid = childFamily.id;
    family.Y = childFamily.Y - _constants__WEBPACK_IMPORTED_MODULE_0__.SIZE;
    family.X = (0,_utils_units__WEBPACK_IMPORTED_MODULE_1__.getUnitX)(childFamily, childUnit);
};


/***/ }),

/***/ "./lib/store.js":
/*!**********************!*\
  !*** ./lib/store.js ***!
  \**********************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "default": () => (__WEBPACK_DEFAULT_EXPORT__)
/* harmony export */ });
/* harmony import */ var _utils__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./utils */ "./lib/utils/index.js");
/* harmony import */ var _utils_family__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./utils/family */ "./lib/utils/family.js");
/* harmony import */ var _types__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./types */ "./lib/types.js");



class Store {
    constructor(nodes, rootId) {
        if (!nodes.find((0,_utils__WEBPACK_IMPORTED_MODULE_0__.withId)(rootId)))
            throw new ReferenceError();
        this.nextId = 0;
        this.families = new Map();
        this.nodes = (0,_utils__WEBPACK_IMPORTED_MODULE_0__.toMap)(nodes);
        this.root = this.nodes.get(rootId);
    }
    getNextId() {
        return ++this.nextId;
    }
    getNode(id) {
        return this.nodes.get(id);
    }
    getNodes(ids) {
        return ids.map((id) => this.getNode(id));
    }
    getFamily(id) {
        return this.families.get(id);
    }
    get familiesArray() {
        return [...this.families.values()];
    }
    get rootFamilies() {
        return this.familiesArray.filter((0,_utils_family__WEBPACK_IMPORTED_MODULE_1__.withType)(_types__WEBPACK_IMPORTED_MODULE_2__.FamilyType.root));
    }
    get rootFamily() {
        return this.rootFamilies.find((family) => family.main);
    }
}
/* harmony default export */ const __WEBPACK_DEFAULT_EXPORT__ = (Store);


/***/ }),

/***/ "./lib/types.js":
/*!**********************!*\
  !*** ./lib/types.js ***!
  \**********************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   FamilyType: () => (/* binding */ FamilyType),
/* harmony export */   Gender: () => (/* binding */ Gender),
/* harmony export */   RelType: () => (/* binding */ RelType)
/* harmony export */ });
var Gender;
(function (Gender) {
    Gender["male"] = "male";
    Gender["female"] = "female";
})(Gender || (Gender = {}));
var RelType;
(function (RelType) {
    RelType["blood"] = "blood";
    RelType["married"] = "married";
    RelType["divorced"] = "divorced";
    RelType["adopted"] = "adopted";
    RelType["half"] = "half";
})(RelType || (RelType = {}));
var FamilyType;
(function (FamilyType) {
    FamilyType["root"] = "root";
    FamilyType["child"] = "child";
    FamilyType["parent"] = "parent";
})(FamilyType || (FamilyType = {}));


/***/ }),

/***/ "./lib/utils/arrangeParentsIn.js":
/*!***************************************!*\
  !*** ./lib/utils/arrangeParentsIn.js ***!
  \***************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   arrangeParentsIn: () => (/* binding */ arrangeParentsIn)
/* harmony export */ });
/* harmony import */ var _constants__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../constants */ "./lib/constants.js");
/* harmony import */ var _index__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./index */ "./lib/utils/index.js");
/* harmony import */ var _family__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./family */ "./lib/utils/family.js");



const calcShifts = (units, ids) => units.reduce((acc, unit) => {
    const index = unit.nodes.findIndex((0,_index__WEBPACK_IMPORTED_MODULE_1__.withIds)(ids));
    if (index !== -1)
        acc.push(unit.pos + index * _constants__WEBPACK_IMPORTED_MODULE_0__.SIZE);
    return acc;
}, []);
const middle = (values) => {
    const result = (values[0] + values[values.length - 1]) / 2;
    return Number.isNaN(result) ? 0 : result;
};
const arrangeParentsIn = (family) => {
    if (!family.parents.length || family.children.length <= 1)
        return;
    family.parents.forEach((unit) => {
        const ids = unit.nodes[0].children.map((0,_index__WEBPACK_IMPORTED_MODULE_1__.prop)('id'));
        unit.pos = Math.floor(middle(calcShifts(family.children, ids)) - ((0,_family__WEBPACK_IMPORTED_MODULE_2__.unitNodesCount)(family.parents) - 1));
    });
};


/***/ }),

/***/ "./lib/utils/correctPositions.js":
/*!***************************************!*\
  !*** ./lib/utils/correctPositions.js ***!
  \***************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   correctPositions: () => (/* binding */ correctPositions)
/* harmony export */ });
/* harmony import */ var _types__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../types */ "./lib/types.js");
/* harmony import */ var _index__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./index */ "./lib/utils/index.js");
/* harmony import */ var _family__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./family */ "./lib/utils/family.js");
/* harmony import */ var _units__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ./units */ "./lib/utils/units.js");




const alignGenerations = (families, root) => {
    const parents = families.find((family) => family.cid === root.id);
    if (parents) {
        const shift = (0,_units__WEBPACK_IMPORTED_MODULE_3__.getUnitX)(parents, parents.children[0]) - (0,_units__WEBPACK_IMPORTED_MODULE_3__.getUnitX)(root, root.parents[0]);
        families
            .filter((0,_family__WEBPACK_IMPORTED_MODULE_2__.withType)(_types__WEBPACK_IMPORTED_MODULE_0__.FamilyType.child, _types__WEBPACK_IMPORTED_MODULE_0__.FamilyType.root))
            .forEach((family) => (family.X += shift));
    }
};
const correct = (families, coordinate) => {
    const shift = (0,_index__WEBPACK_IMPORTED_MODULE_1__.min)(families.map((0,_index__WEBPACK_IMPORTED_MODULE_1__.prop)(coordinate))) * -1;
    if (shift !== 0)
        families.forEach((family) => (family[coordinate] += shift));
};
const correctPositions = (store) => {
    const families = store.familiesArray;
    alignGenerations(families, store.rootFamily);
    correct(families, 'Y');
    correct(families, 'X');
    return store;
};


/***/ }),

/***/ "./lib/utils/createChildUnitsFunc.js":
/*!*******************************************!*\
  !*** ./lib/utils/createChildUnitsFunc.js ***!
  \*******************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   createChildUnitsFunc: () => (/* binding */ createChildUnitsFunc)
/* harmony export */ });
/* harmony import */ var _getSpouseNodesFunc__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./getSpouseNodesFunc */ "./lib/utils/getSpouseNodesFunc.js");
/* harmony import */ var _units__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./units */ "./lib/utils/units.js");


const toArray = (nodes) => nodes.map((node) => Array.of(node));
const createChildUnitsFunc = (store) => {
    const getSpouseNodes = (0,_getSpouseNodesFunc__WEBPACK_IMPORTED_MODULE_0__.getSpouseNodesFunc)(store);
    return (familyId, child) => {
        const { left, middle, right } = getSpouseNodes([child]);
        return [...toArray(left), middle, ...toArray(right)].map((nodes) => (0,_units__WEBPACK_IMPORTED_MODULE_1__.newUnit)(familyId, nodes, true));
    };
};


/***/ }),

/***/ "./lib/utils/family.js":
/*!*****************************!*\
  !*** ./lib/utils/family.js ***!
  \*****************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   bottomOf: () => (/* binding */ bottomOf),
/* harmony export */   getParentsX: () => (/* binding */ getParentsX),
/* harmony export */   heightOf: () => (/* binding */ heightOf),
/* harmony export */   newFamily: () => (/* binding */ newFamily),
/* harmony export */   rightOf: () => (/* binding */ rightOf),
/* harmony export */   unitNodesCount: () => (/* binding */ unitNodesCount),
/* harmony export */   widthOf: () => (/* binding */ widthOf),
/* harmony export */   withType: () => (/* binding */ withType)
/* harmony export */ });
/* harmony import */ var _constants__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../constants */ "./lib/constants.js");
/* harmony import */ var _index__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./index */ "./lib/utils/index.js");
/* harmony import */ var _units__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./units */ "./lib/utils/units.js");



const newFamily = (id, type, main = false) => ({
    id,
    type,
    main,
    Y: 0,
    X: 0,
    parents: [],
    children: [],
});
const withType = (...types) => (item) => types.includes(item.type);
const widthOf = (family) => (0,_index__WEBPACK_IMPORTED_MODULE_1__.max)([...family.parents, ...family.children].map(_units__WEBPACK_IMPORTED_MODULE_2__.rightSide));
const heightOf = (family) => [family.parents.length, family.children.length].filter(Boolean).length * _constants__WEBPACK_IMPORTED_MODULE_0__.SIZE;
const rightOf = (family) => family.X + widthOf(family);
const bottomOf = (family) => family.Y + heightOf(family);
const unitNodesCount = (units) => units.reduce((acc, b) => acc + (0,_units__WEBPACK_IMPORTED_MODULE_2__.nodeCount)(b), 0);
const getParentsX = (family, unit) => {
    return unit ? (0,_units__WEBPACK_IMPORTED_MODULE_2__.getUnitX)(family, unit) + (0,_units__WEBPACK_IMPORTED_MODULE_2__.nodeCount)(unit) : 0;
};


/***/ }),

/***/ "./lib/utils/getCanvasSize.js":
/*!************************************!*\
  !*** ./lib/utils/getCanvasSize.js ***!
  \************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   getCanvasSize: () => (/* binding */ getCanvasSize)
/* harmony export */ });
/* harmony import */ var _index__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./index */ "./lib/utils/index.js");
/* harmony import */ var _family__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./family */ "./lib/utils/family.js");


const getCanvasSize = (families) => ({
    width: (0,_index__WEBPACK_IMPORTED_MODULE_0__.max)(families.map(_family__WEBPACK_IMPORTED_MODULE_1__.rightOf)),
    height: (0,_index__WEBPACK_IMPORTED_MODULE_0__.max)(families.map(_family__WEBPACK_IMPORTED_MODULE_1__.bottomOf)),
});


/***/ }),

/***/ "./lib/utils/getExtendedNodes.js":
/*!***************************************!*\
  !*** ./lib/utils/getExtendedNodes.js ***!
  \***************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   getExtendedNodes: () => (/* binding */ getExtendedNodes)
/* harmony export */ });
/* harmony import */ var _units__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./units */ "./lib/utils/units.js");
/* harmony import */ var _hasHiddenRelatives__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./hasHiddenRelatives */ "./lib/utils/hasHiddenRelatives.js");
/* harmony import */ var _constants__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ../constants */ "./lib/constants.js");
/* harmony import */ var _types__WEBPACK_IMPORTED_MODULE_3__ = __webpack_require__(/*! ../types */ "./lib/types.js");




const extendNode = (family) => (unit) => unit.nodes.map((node, idx) => (Object.assign(Object.assign({}, node), { top: family.Y + (unit.child && !!family.parents.length ? _constants__WEBPACK_IMPORTED_MODULE_2__.SIZE : 0), left: (0,_units__WEBPACK_IMPORTED_MODULE_0__.getUnitX)(family, unit) + idx * _constants__WEBPACK_IMPORTED_MODULE_2__.SIZE, hasSubTree: (0,_hasHiddenRelatives__WEBPACK_IMPORTED_MODULE_1__.hasHiddenRelatives)(family, node) })));
const getParentNodes = (family) => ([_types__WEBPACK_IMPORTED_MODULE_3__.FamilyType.root, _types__WEBPACK_IMPORTED_MODULE_3__.FamilyType.parent].includes(family.type) ? family.parents : []).map(extendNode(family));
const getChildNodes = (family) => ([_types__WEBPACK_IMPORTED_MODULE_3__.FamilyType.root, _types__WEBPACK_IMPORTED_MODULE_3__.FamilyType.child].includes(family.type) ? family.children : []).map(extendNode(family));
const mapFamily = (family) => [getParentNodes(family), getChildNodes(family)].flat(2);
const getExtendedNodes = (families) => families.map(mapFamily).flat();


/***/ }),

/***/ "./lib/utils/getSpouseNodesFunc.js":
/*!*****************************************!*\
  !*** ./lib/utils/getSpouseNodesFunc.js ***!
  \*****************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   getSpouseNodesFunc: () => (/* binding */ getSpouseNodesFunc)
/* harmony export */ });
/* harmony import */ var _constants__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../constants */ "./lib/constants.js");
/* harmony import */ var _types__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ../types */ "./lib/types.js");
/* harmony import */ var _index__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./index */ "./lib/utils/index.js");



const inDescOrderOfChildCount = (a, b) => b.children.length - a.children.length;
const getSpouse = (store, spouses) => {
    const toNode = (0,_index__WEBPACK_IMPORTED_MODULE_2__.relToNode)(store);
    const married = spouses.find((0,_index__WEBPACK_IMPORTED_MODULE_2__.withRelType)(_types__WEBPACK_IMPORTED_MODULE_1__.RelType.married));
    if (married)
        return toNode(married);
    if (spouses.length >= 1)
        return spouses.map(toNode).sort(inDescOrderOfChildCount)[0];
    return;
};
const getCoupleNodes = (store, target) => {
    return [target, getSpouse(store, target.spouses)]
        .filter((node) => Boolean(node))
        .sort((0,_index__WEBPACK_IMPORTED_MODULE_2__.byGender)(store.root.gender));
};
const excludeRel = (target) => (rel) => rel.id !== target.id;
const getSpouseNodesFunc = (store) => {
    const toNode = (0,_index__WEBPACK_IMPORTED_MODULE_2__.relToNode)(store);
    return (parents) => {
        let middle = parents;
        if (middle.length !== _constants__WEBPACK_IMPORTED_MODULE_0__.NODES_IN_COUPLE)
            middle = getCoupleNodes(store, middle[0]);
        const result = { left: [], middle, right: [] };
        if (middle.length === _constants__WEBPACK_IMPORTED_MODULE_0__.NODES_IN_COUPLE) {
            const [first, second] = middle;
            result.left = first.spouses.filter(excludeRel(second)).map(toNode);
            result.right = second.spouses.filter(excludeRel(first)).map(toNode);
        }
        return result;
    };
};


/***/ }),

/***/ "./lib/utils/hasHiddenRelatives.js":
/*!*****************************************!*\
  !*** ./lib/utils/hasHiddenRelatives.js ***!
  \*****************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   hasHiddenRelatives: () => (/* binding */ hasHiddenRelatives)
/* harmony export */ });
/* harmony import */ var _types__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../types */ "./lib/types.js");
/* harmony import */ var _index__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./index */ "./lib/utils/index.js");
/* harmony import */ var _units__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./units */ "./lib/utils/units.js");



const inUnits = (units, nodeId) => units.some((unit) => unit.nodes.some((0,_index__WEBPACK_IMPORTED_MODULE_1__.withId)(nodeId)));
const hasHiddenRelatives = (family, node) => {
    if (family.type !== _types__WEBPACK_IMPORTED_MODULE_0__.FamilyType.child && inUnits(family.parents, node.id)) {
        return ((family.type === _types__WEBPACK_IMPORTED_MODULE_0__.FamilyType.parent &&
            (node.children.length > 1 || node.spouses.length > 1)) ||
            (!node.parents.length && !!node.siblings.length));
    }
    if (family.type !== _types__WEBPACK_IMPORTED_MODULE_0__.FamilyType.parent && inUnits(family.children, node.id)) {
        const parentIds = family.parents.length ? (0,_units__WEBPACK_IMPORTED_MODULE_2__.nodeIds)(family.parents[0]) : [];
        return (!node.parents.some((0,_index__WEBPACK_IMPORTED_MODULE_1__.withIds)(parentIds)) && (!!node.parents.length || !!node.siblings.length));
    }
    return false;
};


/***/ }),

/***/ "./lib/utils/index.js":
/*!****************************!*\
  !*** ./lib/utils/index.js ***!
  \****************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   byGender: () => (/* binding */ byGender),
/* harmony export */   hasDiffParents: () => (/* binding */ hasDiffParents),
/* harmony export */   inAscOrder: () => (/* binding */ inAscOrder),
/* harmony export */   max: () => (/* binding */ max),
/* harmony export */   min: () => (/* binding */ min),
/* harmony export */   nextIndex: () => (/* binding */ nextIndex),
/* harmony export */   pipe: () => (/* binding */ pipe),
/* harmony export */   prop: () => (/* binding */ prop),
/* harmony export */   relToNode: () => (/* binding */ relToNode),
/* harmony export */   toMap: () => (/* binding */ toMap),
/* harmony export */   unique: () => (/* binding */ unique),
/* harmony export */   withId: () => (/* binding */ withId),
/* harmony export */   withIds: () => (/* binding */ withIds),
/* harmony export */   withRelType: () => (/* binding */ withRelType)
/* harmony export */ });
const nextIndex = (index) => index + 1;
const prop = (name) => (item) => item[name];
const withId = (id) => (item) => item.id === id;
const withIds = (ids, include = true) => (item) => ids.includes(item.id) === include;
const unique = (item, index, arr) => arr.indexOf(item) === index;
const inAscOrder = (v1, v2) => v1 - v2;
const pipe = (...fus) => (init) => fus.reduce((res, fn) => fn(res), init);
const min = (arr) => Math.min.apply(null, arr);
const max = (arr) => Math.max.apply(null, arr);
const toMap = (items) => new Map(items.map((item) => [item.id, Object.assign({}, item)]));
const hasDiffParents = (node) => node.parents.map(prop('type')).filter(unique).length > 1;
const byGender = (target) => (_, b) => (b.gender !== target ? -1 : 1);
const relToNode = (store) => (rel) => store.getNode(rel.id);
const withRelType = (...types) => (item) => types.includes(item.type);


/***/ }),

/***/ "./lib/utils/setDefaultUnitShift.js":
/*!******************************************!*\
  !*** ./lib/utils/setDefaultUnitShift.js ***!
  \******************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   setDefaultUnitShift: () => (/* binding */ setDefaultUnitShift)
/* harmony export */ });
/* harmony import */ var _index__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./index */ "./lib/utils/index.js");
/* harmony import */ var _units__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./units */ "./lib/utils/units.js");
/* harmony import */ var _family__WEBPACK_IMPORTED_MODULE_2__ = __webpack_require__(/*! ./family */ "./lib/utils/family.js");



const arrangeUnitsIn = (family) => {
    const diff = (0,_family__WEBPACK_IMPORTED_MODULE_2__.unitNodesCount)(family.parents) - (0,_family__WEBPACK_IMPORTED_MODULE_2__.unitNodesCount)(family.children);
    if (diff === 0)
        return;
    if (diff > 0)
        (0,_units__WEBPACK_IMPORTED_MODULE_1__.correctUnitsShift)(family.children, diff);
    else
        (0,_units__WEBPACK_IMPORTED_MODULE_1__.correctUnitsShift)(family.parents, Math.abs(diff));
};
const setDefaultUnitShift = (family) => {
    const units = [family.parents, family.children];
    units.forEach(_units__WEBPACK_IMPORTED_MODULE_1__.arrangeInOrder);
    arrangeUnitsIn(family);
    const start = (0,_index__WEBPACK_IMPORTED_MODULE_0__.min)(units.flat().map((0,_index__WEBPACK_IMPORTED_MODULE_0__.prop)('pos')));
    if (start !== 0)
        units.forEach((items) => (0,_units__WEBPACK_IMPORTED_MODULE_1__.correctUnitsShift)(items, start * -1));
};


/***/ }),

/***/ "./lib/utils/units.js":
/*!****************************!*\
  !*** ./lib/utils/units.js ***!
  \****************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

"use strict";
__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   arrangeInOrder: () => (/* binding */ arrangeInOrder),
/* harmony export */   correctUnitsShift: () => (/* binding */ correctUnitsShift),
/* harmony export */   getUnitX: () => (/* binding */ getUnitX),
/* harmony export */   hasChildren: () => (/* binding */ hasChildren),
/* harmony export */   newUnit: () => (/* binding */ newUnit),
/* harmony export */   nodeCount: () => (/* binding */ nodeCount),
/* harmony export */   nodeIds: () => (/* binding */ nodeIds),
/* harmony export */   rightSide: () => (/* binding */ rightSide),
/* harmony export */   sameAs: () => (/* binding */ sameAs),
/* harmony export */   unitsToNodes: () => (/* binding */ unitsToNodes)
/* harmony export */ });
/* harmony import */ var _constants__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ../constants */ "./lib/constants.js");
/* harmony import */ var _index__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./index */ "./lib/utils/index.js");


const newUnit = (fid, nodes, isChild = false) => ({
    fid,
    child: isChild,
    nodes: [...nodes],
    pos: 0,
});
const nodeIds = (unit) => unit.nodes.map((0,_index__WEBPACK_IMPORTED_MODULE_1__.prop)('id'));
const nodeCount = (unit) => unit.nodes.length;
const hasChildren = (unit) => unit.nodes.some((node) => node.children.length);
const rightSide = (unit) => unit.pos + nodeCount(unit) * _constants__WEBPACK_IMPORTED_MODULE_0__.SIZE;
const sameAs = (target) => (unit) => nodeIds(target).join('') === nodeIds(unit).join('');
const getUnitX = (family, unit) => family.X + unit.pos;
const unitsToNodes = (units) => units.map((0,_index__WEBPACK_IMPORTED_MODULE_1__.prop)('nodes')).flat();
const arrangeInOrder = (units) => {
    units.forEach((unit, idx, self) => (unit.pos = idx === 0 ? 0 : rightSide(self[idx - 1])));
};
const correctUnitsShift = (units, shift) => units.forEach((unit) => (unit.pos += shift));


/***/ })

/******/ 	});
/************************************************************************/
/******/ 	// The module cache
/******/ 	var __webpack_module_cache__ = {};
/******/ 	
/******/ 	// The require function
/******/ 	function __webpack_require__(moduleId) {
/******/ 		// Check if module is in cache
/******/ 		var cachedModule = __webpack_module_cache__[moduleId];
/******/ 		if (cachedModule !== undefined) {
/******/ 			return cachedModule.exports;
/******/ 		}
/******/ 		// Create a new module (and put it into the cache)
/******/ 		var module = __webpack_module_cache__[moduleId] = {
/******/ 			// no module.id needed
/******/ 			// no module.loaded needed
/******/ 			exports: {}
/******/ 		};
/******/ 	
/******/ 		// Execute the module function
/******/ 		__webpack_modules__[moduleId](module, module.exports, __webpack_require__);
/******/ 	
/******/ 		// Return the exports of the module
/******/ 		return module.exports;
/******/ 	}
/******/ 	
/************************************************************************/
/******/ 	/* webpack/runtime/define property getters */
/******/ 	(() => {
/******/ 		// define getter functions for harmony exports
/******/ 		__webpack_require__.d = (exports, definition) => {
/******/ 			for(var key in definition) {
/******/ 				if(__webpack_require__.o(definition, key) && !__webpack_require__.o(exports, key)) {
/******/ 					Object.defineProperty(exports, key, { enumerable: true, get: definition[key] });
/******/ 				}
/******/ 			}
/******/ 		};
/******/ 	})();
/******/ 	
/******/ 	/* webpack/runtime/hasOwnProperty shorthand */
/******/ 	(() => {
/******/ 		__webpack_require__.o = (obj, prop) => (Object.prototype.hasOwnProperty.call(obj, prop))
/******/ 	})();
/******/ 	
/******/ 	/* webpack/runtime/make namespace object */
/******/ 	(() => {
/******/ 		// define __esModule on exports
/******/ 		__webpack_require__.r = (exports) => {
/******/ 			if(typeof Symbol !== 'undefined' && Symbol.toStringTag) {
/******/ 				Object.defineProperty(exports, Symbol.toStringTag, { value: 'Module' });
/******/ 			}
/******/ 			Object.defineProperty(exports, '__esModule', { value: true });
/******/ 		};
/******/ 	})();
/******/ 	
/************************************************************************/
var __webpack_exports__ = {};
// This entry needs to be wrapped in an IIFE because it needs to be isolated against other modules in the chunk.
(() => {
/*!**************************!*\
  !*** ./webpack/entry.js ***!
  \**************************/
// Webpack entry file for Unity/Puerts integration
// This file imports the relatives-tree library and exposes it to the global scope

const calcTree = __webpack_require__(/*! ../lib/index.js */ "./lib/index.js");

// The imported module is the default export which is the calcTree function itself
// Expose it to global scope for Puerts access
global.RelativesTreeLib = calcTree;
global.calcTree = calcTree;

// Also create a namespace object for compatibility
global.RelativesTree = {
    calcTree: calcTree,
    default: calcTree
};

// Log to confirm the library is loaded (can be removed in production)
if (typeof console !== 'undefined') {
    console.log('[RelativesTree] Library loaded and exposed to global scope');
    console.log('Type of calcTree:', typeof calcTree);
}
})();

__webpack_exports__ = __webpack_exports__["default"];
/******/ 	return __webpack_exports__;
/******/ })()
;
});
//# sourceMappingURL=relatives-tree.bundle.js.map