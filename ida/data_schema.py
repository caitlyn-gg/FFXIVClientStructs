from typing import Optional
from dataclasses import dataclass, field


@dataclass
class DefinedDataClassInstance:
    ea: int
    pointer: bool = False
    name: Optional[str] = None


@dataclass
class DefinedDataClassVtable:
    ea: int
    base: Optional[str] = None


@dataclass
class DefinedDataClassFunction:
    num: int
    name: str


@dataclass
class DefinedDataClass:
    name: str
    instances: list[DefinedDataClassInstance] = field(default_factory=list)
    vtbls: list[DefinedDataClassVtable] = field(default_factory=list)
    functions: list[DefinedDataClassFunction] = field(default_factory=list)
    vfuncs: list[DefinedDataClassFunction] = field(default_factory=list)


@dataclass
class DefinedData:
    classes: list[DefinedDataClass] = field(default_factory=list)
